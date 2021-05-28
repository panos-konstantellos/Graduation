import { Container, IContainerDefinition } from './Container';

interface IActionContainerDefinition extends IContainerDefinition
{
}

class ActionContainer extends Container<IActionContainerDefinition>
{    
}

export default ActionContainer;
export { IActionContainerDefinition, ActionContainer };