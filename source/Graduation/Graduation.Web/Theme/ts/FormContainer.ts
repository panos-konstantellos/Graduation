import _ from 'lodash';

import { Container, IContainerDefinition } from './Container';

interface IFormContainerDefinition extends IContainerDefinition
{
}

class FormContainer extends Container<IFormContainerDefinition>
{
    private _template:string;
    
    private get _formWrapper(): HTMLFormElement
    {
        return this._wrapper as HTMLFormElement;
    } 

    protected GetDefaultDefinition(): IFormContainerDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
            ElementType: 'form',
        });
    };

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._formWrapper.action = 'index-2.html';
    }
}

export default FormContainer;
export { IFormContainerDefinition, FormContainer };