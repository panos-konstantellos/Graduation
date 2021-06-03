interface IDataSourceOptions
{
    Name: string;
    ValueField: string;
    MasterControlId?: string;
}

interface ILookupDataSourceOptions extends IDataSourceOptions
{
    TextField: string;
}

export default IDataSourceOptions;
export { IDataSourceOptions, ILookupDataSourceOptions };