using I72_Backend.Entities;
using I72_Backend.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace I72_Backend.Interfaces;

public interface IManagementService
{
    public void CreateTables(CreateListTablesDto dto);

    public List<Dictionary<string, object>> GetBarChartData(String table, String columnX, String columnY,
        AggregationType aggregationType);

    public String PerformInsert(String table, Dictionary<String, String> values);

    public String PerformBatchUpdate(String table, Dictionary<String, String?> whereCondition,
        Dictionary<String, String?> updateFields);

    public String PerformDeleteById(String table, String column, String id);

    public List<Dictionary<String, object>> PerformRead(String table, PaginationParams pageParams,
        Dictionary<String, String?> conditions);

    public String PerformBatchDelete(String table, Dictionary<String, String?> whereConditions);

 public List<Dictionary<string, object>> GetAggregateChartData(String table, String columnX, String columnY, AggregationType aggregationType);
    FileStreamResult GeneratePdfReport(string table, string x, string y, string aggregationFunction);  //to match the service implementation
}