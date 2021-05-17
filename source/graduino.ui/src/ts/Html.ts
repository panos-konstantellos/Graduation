class Html 
{
    static FindParent(element: HTMLElement, selector: string): HTMLElement
    {
        debugger;

        while (element = element.parentElement)
        {
            var findFn = element.matches || (element as any).matchesSelector;

            var element = findFn.call(element, selector) as HTMLElement;

            if(!!element)
            {
                break;
            }
        }
        
        return element;
    }
}

export default Html;