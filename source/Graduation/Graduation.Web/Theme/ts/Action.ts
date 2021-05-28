
import _ from 'lodash';

import { Control, IControlDefinition } from './Control';

interface IActionControlDefinition extends IControlDefinition
{
}

abstract class ActionControl<T extends IActionControlDefinition> extends Control<T>
{
    public abstract get Enabled(): boolean;

    protected GetDefaultDefinition(): T
    {
        return _.extend({}, super.GetDefaultDefinition(), {
        });
    };
    
    public abstract Execute(): void;
}

export default ActionControl;
export { IActionControlDefinition, ActionControl };