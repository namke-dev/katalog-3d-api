using katalog_3d_api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace katalog_3d_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity> : ControllerBase where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public GenericController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _repository.GetAll();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TEntity entity)
        {
            var addedEntity = await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = addedEntity.GetType().GetProperty("Id").GetValue(addedEntity) }, addedEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TEntity entity)
        {
            var updatedEntity = await _repository.UpdateAsync(entity);
            if (updatedEntity == null)
            {
                return NotFound();
            }

            return Ok(updatedEntity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedEntity = await _repository.DeleteAsync(id);
            if (deletedEntity == null)
            {
                return NotFound();
            }

            return Ok(deletedEntity);
        }
    }

}