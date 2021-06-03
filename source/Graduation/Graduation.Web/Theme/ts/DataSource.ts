import _ from "lodash";
import Observable from "./Observable";

class DataSource
{
    private __data: Observable;
    private __name: string;

    public get Data(): Array<Observable>
    {
        var result = [];
        
        Object.getOwnPropertyNames(this.__data).forEach(propertyName => 
        {
            var value = this.__data[propertyName];

            if(value instanceof Observable)
            {
                result.push(value);
            }
        });

        return result;
    }

    public get Name(): string
    {
        return this.__name.slice();
    }

    public get HasChanges(): boolean
    {
        return this.__data.HasChanges;
    }

    constructor(name: string, data: Array<any>)
    {
        this.__name = name;

        if(!(data instanceof Array))
        {
            throw new Error('Invalid Operation');
        }

        this.__data = new Observable(data);
    }

    public DiscardChanges(): void
    {
        this.__data.DiscardChanges();
    }

}

export default DataSource;