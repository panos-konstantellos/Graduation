import Guid from './Guid';
import { Control, IControlDefinition } from './Control';
import _ from 'lodash';

type Func<TArgs extends any[], TResult> = (...args: TArgs) => TResult; 
type Action<TArgs extends any[]> = Func<TArgs, undefined>; 

interface IContainerDefinition extends IControlDefinition
{
    Children: Control<IControlDefinition>[];
}

abstract class Container<T extends IContainerDefinition> extends Control<T>
{
    public Build():void
    {
        this._options.Children.forEach(x => x.Build());
    }
    
    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._options.Children.forEach(x => x.Render(this._wrapper));
    }

    public Bind(): void
    {
        this._options.Children.forEach(x => x.Bind());
    }

    public FindControl(predicate: Func<[Control<IControlDefinition>], boolean>): Control<IControlDefinition>
    {
        if(predicate(this))
        {
            return this;
        }

        var result = _.find(this._options.Children, x => 
        {
            if(predicate(x))
            {
                return true;
            }
        });
        
        if(!!result)
        {
            return result;
        }

        for(var child in this._options.Children)
        {
            if(!((child as any).FindControl === 'function'))
            {
                continue;
            }

            result = (child as any).FindControl(predicate);

            if(!!result)
            {
                return result;
            }
        }

        return undefined;
    }
}

export default Container;
export { Container, IContainerDefinition };