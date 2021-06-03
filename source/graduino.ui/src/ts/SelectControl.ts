import _ from 'lodash';

import { Control, IControlDefinition } from './Control';
import { ILookupDataSourceOptions  } from './DataSourceOptions';

interface ISelectControlDefinition extends IControlDefinition
{
    Title: string,
    AriaLabel: string,
    PleaseSelect: boolean,
    Required?: boolean,
    LookupDataSource: ILookupDataSourceOptions
}

class SelectControl extends Control<ISelectControlDefinition>
{
    private _template:string; 

    protected GetDefaultDefinition(): ISelectControlDefinition
    {
        return _.extend({}, super.GetDefaultDefinition(), {
            Title: "text",
            AriaLabel: "text",
            PleaseSelect: false,
            Required: false
        });
    };

    public Build():void
    {
        this._template = `
<div class="input-group my-3">
    <span class="input-group-text" id="${this._options.Id}-at">${this._options.Title}</span>
    <select class="form-select" aria-label="${this._options.AriaLabel}"
        aria-describedby="${this._options.Id}-at" ${this._options.Required ?? false ? 'required': ''}>
    </select>
</div>`;
    }

    public Render(wrapper: HTMLElement): void
    {
        super.Render(wrapper);

        this._wrapper.innerHTML = this._template;
    }

    public Bind(): void
    {
        var selectElement = this._wrapper.getElementsByClassName('form-select')[0] as HTMLSelectElement;

        var options = [];
        
        if(this._options.PleaseSelect ?? false)
        {
            options.push({
                text: 'Παρακαλώ επίλεξε',
                value: '',
                disabled: true
            });
        }

        var dataSource = this._dataContext.Get(this._options.LookupDataSource.Name);

        options = _.concat([], options, _.map(dataSource.Data, (x, i) => 
        {
            return { 
                text: x.GetProperty(this._options.LookupDataSource.TextField),
                value: x.GetProperty(this._options.LookupDataSource.ValueField),
                disabled: false
            };
        }));

        options.map((x, i) =>
        {
            var option = document.createElement('option');

            option.text = x.text;
            option.value = x.value;
            option.disabled = x.disabled;

            option.selected = i == 0;

            return option;
        }).forEach(x =>
        {
            selectElement.add(x);
        });

    }
}

export default SelectControl;
export { ISelectControlDefinition, SelectControl };