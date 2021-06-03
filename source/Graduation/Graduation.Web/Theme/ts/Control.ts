import _ from 'lodash';

import Guid from './Guid';
import { DataContext } from './DataContext';

interface IControlDefinition
{
    Id: string,
    ElementType?: string,
    CssClasses?: string[],
}

class Control<T extends IControlDefinition>
{
    protected _options:T;
    protected _wrapper: HTMLElement; 
    protected _dataContext: DataContext;

    constructor(options: T, dataContext: DataContext)
    {
        this._options = _.extend({}, this.GetDefaultDefinition(), options);
        this._dataContext = dataContext;
    }

    protected GetDefaultDefinition(): T
    {
        return _.extend({},{
            Id: Guid.NewGuid(),
            ElementType: 'div'
        }) as T;
    };

    public Build(): void
    {
    }

    public Render(wrapper: HTMLElement): void
    {
        this._wrapper = document.createElement(this._options.ElementType);
        this._wrapper.setAttribute('data-id', this._options.Id);
        (this._wrapper as any).Control = this;
        
        (this._options.CssClasses ?? []).forEach(x => this._wrapper.classList.add(x));

        wrapper.appendChild(this._wrapper);
    }
    
    public Bind(): void
    {
    }
}

export { Control, IControlDefinition };