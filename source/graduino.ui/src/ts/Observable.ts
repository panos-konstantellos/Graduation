import _ from 'lodash';

class Observable
{
    private __internalObject: Object | Array<any>;
    private __originalValues: Object | Array<any>;
    private __currentValues: Object | Array<any>;
    
    constructor(obj: Object | Array<any>)
    {
        this.__internalObject = obj;
        
        if(obj instanceof Array)
        {
            this.__originalValues = _.extend([], JSON.parse(JSON.stringify(obj)));
            this.__currentValues = [];
        }
        else if (obj instanceof Object)
        {
            this.__originalValues = _.extend({}, JSON.parse(JSON.stringify(obj)));
            this.__currentValues = {};
        }
        else
        {
            throw new Error('Invalid Operation');
        }
        
        Object.keys(this.__internalObject).forEach(x =>
        {
            Object.defineProperty(this, x, 
            {
                get() {
                    return this.GetProperty(x);
                },
                set(value) {
                    this.SetProperty(x, value);
                }
            });

            this.SetProperty(x, this.__internalObject[x]);
        });
    }
    
    public GetProperty(propertyName: string): any
    {
        if(!!!_.some(Object.keys(this.__internalObject), x => x === propertyName))
        {
            throw new Error(`Invalid property name ${propertyName}`);
        }

        return this.__currentValues[propertyName];
    }

    public SetProperty(propertyName: string, value: any): void
    {
        if(!!!_.some(Object.keys(this.__internalObject), x => x === propertyName))
        {
            throw new Error(`Invalid property name ${propertyName}`);
        }

        if(value instanceof Array)
        {
            this.__currentValues[propertyName] = new Observable(value);

            this.__internalObject[propertyName] = value;

            return;
        }

        if(value instanceof Object)
        {
            this.__currentValues[propertyName] = new Observable(value);
            
            this.__internalObject[propertyName] = value;

            return;
        }

        this.__internalObject[propertyName] = this.__currentValues[propertyName] = value;
    }

    public get HasChanges(): boolean
    {
        return _.some(Object.keys(this.__internalObject), x =>
        {
            var currentValue = this.__currentValues[x];

            if(currentValue instanceof Observable)
            {
                return currentValue.HasChanges;
            }
            
            return currentValue !== this.__originalValues[x]
        });
    }

    public DiscardChanges(): void
    {
        if(!this.HasChanges)
        {
            return;
        }

        Object.keys(this.__internalObject).forEach(x =>
        {
            var currentValue = this.__currentValues[x];

            if(currentValue instanceof Observable)
            {
                if(currentValue.HasChanges)
                {
                    currentValue.DiscardChanges();
                }

                return;
            }

            if(this.__currentValues[x] !== this.__originalValues[x])
            {
                this.SetProperty(x, this.__originalValues[x]);
            }
        });
    }
}

export default Observable;