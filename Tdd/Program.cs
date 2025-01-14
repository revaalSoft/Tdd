using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start");


        var csvDataSource = new CsvAdapter(new CsvDataSource());
        var sqlDataSource = new SqlAdapter(new SqlDataSource());
        var restApiDataSource = new RestApiAdapter(new RestApiDataSource());


        List<IDataSource> dataSources = new List<IDataSource> { csvDataSource, sqlDataSource, restApiDataSource };


        foreach (var dataSource in dataSources)
        {
            var data = dataSource.GetData();
            Console.WriteLine(data);
        }

        Console.WriteLine("End");
    }


    public interface IDataSource
{
    string GetData();
}


public class CsvDataSource
{
    public string ReadCsvData()
    {
        return "Data from CSV";
    }
}


public class SqlDataSource
{
    public string ExecuteSqlQuery()
    {
        return "Data from SQL";
    }
}

public class RestApiDataSource
{
    public string FetchApiData()
    {
        return "Data from API";
    }
}




public class CsvAdapter : IDataSource
{
    private readonly CsvDataSource _csvDataSource;

    public CsvAdapter(CsvDataSource csvDataSource)
    {
        _csvDataSource = csvDataSource;
    }

    public string GetData()
    {
        return _csvDataSource.ReadCsvData();
    }
}

public class SqlAdapter : IDataSource
{
    private readonly SqlDataSource _sqlDataSource;

    public SqlAdapter(SqlDataSource sqlDataSource)
    {
        _sqlDataSource = sqlDataSource;
    }

    public string GetData()
    {
        return _sqlDataSource.ExecuteSqlQuery();
    }
}


public class RestApiAdapter : IDataSource
{
    private readonly RestApiDataSource _restApiDataSource;

    public RestApiAdapter(RestApiDataSource restApiDataSource)
    {
        _restApiDataSource = restApiDataSource;
    }

    public string GetData()
    {
        return _restApiDataSource.FetchApiData();
    }
}



}
