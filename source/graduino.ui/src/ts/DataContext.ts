import DataSource from './DataSource';

export class DataContext 
{
    private _dataSources: Map<string, DataSource>;

    constructor()
    {
        this._dataSources = new Map<string, DataSource>();
    }

    public AddDataSource(dataSource: DataSource): void
    {
        if (this._dataSources.has(dataSource.Name)) 
        {
            throw new Error('An item has already be added to the collection');
        }

        this._dataSources.set(dataSource.Name, dataSource);
    }

    public Get(dataSourceName: string)
    {
        if (!this._dataSources.has(dataSourceName)) 
        {
            throw new Error('DataSource not found in the backing store.');
        }

        return this._dataSources.get(dataSourceName);
    }
}