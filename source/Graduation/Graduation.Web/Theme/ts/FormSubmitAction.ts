import _ from 'lodash';

import { ActionControl, IActionControlDefinition } from './Action';
import FormContainer, { IFormContainerDefinition } from './FormContainer';
import Html from './Html';

interface IFormSubmitActionControlDefinition extends IActionControlDefinition
{
    FormId?: string;
}

class FormSubmitActionControl extends ActionControl<IFormSubmitActionControlDefinition>
{
    public get Enabled(): boolean
    {
        if(!!!(this._options.FormId ?? ''))
        {
            return false;
        }

        var form = document.querySelector(`[data-id="${this._options.FormId}"]`) as HTMLFormElement;

        return !!form;
    }

    protected GetDefaultDefinition(): IFormSubmitActionControlDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
        });
    };

    public Execute(): void
    {
        if(!!!(this._options.FormId ?? ''))
        {
            return;
        }

        var form = document.querySelector(`[data-id="${this._options.FormId}"]`) as HTMLFormElement;

        if(!!!form)
        {
            return;
        }

        form.submit();
    }
}

export default FormSubmitActionControl;
export { IFormSubmitActionControlDefinition, FormSubmitActionControl };