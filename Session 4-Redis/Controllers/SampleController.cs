using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using  sample.Models;
namespace Session_4_Redis.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SampleController : ControllerBase
{
    private readonly IDistributedCache _distributedCache;
     private readonly Context _contxt;
    public SampleController(IDistributedCache distributedCache, Context contxt){
        _distributedCache = distributedCache;
        _contxt=contxt;
    }
    [HttpGet]
    public IEnumerable<Student> Get()
    {
        // return new List<Student>()
        // {
        //     new Student(){Id=1,Name="Rahim",Age=30},
        //     new Student(){Id=1,Name="Zahra",Age=20},
        //     new Student(){Id=1,Name="Sara",Age=19},
        //     new Student(){Id=1,Name="Marjan",Age=28},
        //     new Student(){Id=1,Name="Vahid",Age=25},
        //
        var data=_distributedCache.GetString("student");
        if (data != null) {
            return JsonSerializer.Deserialize<IEnumerable<Student>>(data);
        }
        else{
            var student=_contxt.Students.ToList();
            _distributedCache.SetString("student",JsonSerializer.Serialize(student));
            return student;
        }
        }
    }

