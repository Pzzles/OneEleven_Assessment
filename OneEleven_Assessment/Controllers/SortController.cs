using Microsoft.AspNetCore.Mvc;
using OneEleven_Assessment.Helpers;
using OneEleven_Assessment.Models;
using OneEleven_Assessment.Repo.Contracts;
using OneEleven_Assessment.Repo.Impl_Class;
using System.Diagnostics;

namespace OneEleven_Assessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SortController : ControllerBase
    {
        private readonly ISorter _sorter;

        public SortController(ISorter sorter)
        {
            _sorter = sorter;
        }

        [HttpPost]
        public IActionResult Post([FromBody] DataInput input)
        {
            if (input == null || string.IsNullOrWhiteSpace(input.Data?.Trim()))
                return BadRequest("Body must contain a non-empty 'data' field.");

            // Spec doesn't address special characters or whitespace.
            // Trimming leading/trailing space to avoid unexpected outputs.
            string trimmedInput = input.Data.Trim();

            char[] result = new char[0];

            try
            {
                result = _sorter.ManualSort(trimmedInput);
                return Ok(new { word = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while processing the request.\n Result: {result.Length}.\n Error: {ex.Message}");
            }
        }
    }
}
