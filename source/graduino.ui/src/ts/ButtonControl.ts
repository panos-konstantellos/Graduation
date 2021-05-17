
import _ from 'lodash';
import ActionControl, { IActionControlDefinition } from './Action';

import { Control, IControlDefinition } from './Control';

interface IButtonControlDefinition extends IControlDefinition
{
    Title: string,
    Type?: string,
    ActionId?: string,
}

class ButtonControl extends Control<IButtonControlDefinition>
{
    private _template:string; 

    private get _action():ActionControl<IActionControlDefinition>
    {
        if(!!!(this._options.ActionId ?? ''))
        {
            return;
        }

        var action = document.querySelector(`[data-id="${this._options.ActionId}"]`);

        if(!!!action)
        {
            return;
        }

        return (action as any).Control as ActionControl<IActionControlDefinition>;
    }

    public get Enabled(): boolean
    {
        var action = this._action;

        if(!!!action)
        {
            return false;
        }

        return action.Enabled;
    }

    protected GetDefaultDefinition(): IButtonControlDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
            Title: "text",
            PlaceHolder: "text",
            AriaLabel: "text",
            ReadOnly: false,
            Type: 'button'
        });
    };

    public Build():void
    {
        this._template = `<button type="${this._options.Type ?? 'button'}" class="btn btn-block btn-primary">${this._options.Title}</button>`;
    }

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.innerHTML = this._template;
    }

    public Bind(): void
    {
        var buttonElement = this._wrapper.getElementsByClassName('btn')[0] as HTMLButtonElement;

        buttonElement.addEventListener('click', x =>
        {
            x.preventDefault();
            x.stopPropagation();

            if(!this.Enabled)
            {
                return;
            }

            var action = this._action;

            if(!action)
            {
                return;
            }

            action.Execute();
        });
    }
}

export default ButtonControl;
export { IButtonControlDefinition, ButtonControl };