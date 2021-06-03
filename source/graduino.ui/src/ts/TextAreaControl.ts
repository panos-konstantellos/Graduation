import _ from 'lodash';

import { Control, IControlDefinition } from './Control';

interface ITextAreaControlDefinition extends IControlDefinition
{
    Title: string,
    PlaceHolder: string,
    AriaLabel: string
}

class TextAreaControl extends Control<ITextAreaControlDefinition>
{
    private _template:string;

    protected GetDefaultDefinition(): ITextAreaControlDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
            Title: "text area",
            PlaceHolder: "text area",
            AriaLabel: "text area"
        });
    };

    public Build():void
    {
        super.Build();

        this._template = `                                        
<div class="input-group my-3">
    <span class="input-group-text" id="${this._options.Id}-at">${this._options.Title}</span>
    <textarea class="form-control" rows="3" placeholder="${this._options.PlaceHolder}" aria-label="${this._options.AriaLabel}"
        aria-describedby="${this._options.Id}-at" required></textarea>
</div>`;
    }

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.innerHTML = this._template;
    }

    public Bind(): void
    {
        super.Bind();
    }
}

export default TextAreaControl;
export { ITextAreaControlDefinition as ITextAreaDefinition, TextAreaControl as TextArea };