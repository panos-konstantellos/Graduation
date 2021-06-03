import _ from 'lodash';

import { Container, IContainerDefinition } from './Container';

interface IColumnContainerDefinition extends IContainerDefinition
{
    Width: number,
    WidthDesktop?: number,
}

class ColumnContainer extends Container<IColumnContainerDefinition>
{
    protected GetDefaultDefinition(): IColumnContainerDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
                Width: 12,
            });
    };

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.classList.add(`col-${this._options.Width}`);
        
        if((this._options.WidthDesktop ?? -1) > 0)
        {
            this._wrapper.classList.add(`col-lg-${this._options.WidthDesktop}`);
        }
    }
}

export default ColumnContainer;
export { IColumnContainerDefinition, ColumnContainer };