
import _ from 'lodash';

import { Control, IControlDefinition } from './Control';

interface ITextControlDefinition extends IControlDefinition
{
    Title: string,
    PlaceHolder: string,
    AriaLabel: string,
    ReadOnly?: boolean, 
    Required?: boolean
}

class TextControl extends Control<ITextControlDefinition>
{
    private _template:string; 

    protected GetDefaultDefinition(): ITextControlDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
            Title: "text",
            PlaceHolder: "text",
            AriaLabel: "text",
            ReadOnly: false,
            Required: false
        });
    };

    public Build():void
    {
        this._template = `
<span class="input-group-text" id="${this._options.Id}-at">${this._options.Title}</span>
<input type="text" class="form-control" placeholder="${this._options.PlaceHolder}" aria-label="${this._options.AriaLabel}"
    aria-describedby="${this._options.Id}-at" ${(this._options.ReadOnly ?? false) ? 'disabled' : ''} ${(this._options.Required ?? false) ? 'required' : ''}>`;
    }

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.classList.add('input-group');
        this._wrapper.classList.add('my-3');

        this._wrapper.innerHTML = this._template;
    }

    public Bind(): void
    {

    }
}

export default TextControl;
export { ITextControlDefinition, TextControl };