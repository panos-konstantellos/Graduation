import { Container, IContainerDefinition } from './Container';

interface IRowContainerDefinition extends IContainerDefinition
{
}

class RowContainer extends Container<IRowContainerDefinition>
{    
    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.classList.add('row');
    }
}

export default RowContainer;
export { IRowContainerDefinition, RowContainer };