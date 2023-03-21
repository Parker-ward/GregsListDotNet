using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GregsListDotNet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService housesService;
    public HousesController(HousesService housesService)
    {
      this.housesService = housesService;
    }
    [HttpGet]
    public ActionResult<List<House>> Find()
    {
      try
      {
        List<House> houses = housesService.Find();
        return Ok(houses);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<House> Find(int id)
    {
      try
      {
        House house = housesService.Find(id);
        return Ok(house);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<House> Create([FromBody] House houseData)
    {
      try
      {
        House house = housesService.Create(houseData);
        return Ok(house);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Remove(int id)
    {
      try
      {
        string message = housesService.Remove(id);
        return Ok(message);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<House> Update(int id, [FromBody] House updateData)
    {
      try
      {
        updateData.Id = id;
        House house = housesService.Update(updateData);
        return Ok(house);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }

}