using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ModuleA
{
    public class TodoOneAppService : ModuleAAppService
    {
        private readonly IRepository<TodoOne, Guid> todoOneRepository;

        public TodoOneAppService(IRepository<TodoOne, Guid> todoOneRepository)
        {
            this.todoOneRepository = todoOneRepository;
        }

        public async Task<List<TodoOneDto>> GetAll()
        {
            return ObjectMapper.Map<List<TodoOne>, List<TodoOneDto>>(await todoOneRepository.GetListAsync());
        }

        public async Task<TodoOneDto> CreateAsync(TodoOneDto todoOneDto)
        {
            var TodoOne = ObjectMapper.Map<TodoOneDto, TodoOne>(todoOneDto);
            var createdTodoOne = await todoOneRepository.InsertAsync(TodoOne);
            return ObjectMapper.Map<TodoOne, TodoOneDto>(createdTodoOne);
        }

        public async Task<TodoOneDto> UpdateAsync(TodoOneDto todoOneDto)
        {
            var TodoOne = ObjectMapper.Map<TodoOneDto, TodoOne>(todoOneDto);
            var createdTodoOne = await todoOneRepository.UpdateAsync(TodoOne);
            return ObjectMapper.Map<TodoOne, TodoOneDto>(createdTodoOne);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var TodoOne = await todoOneRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (TodoOne != null)
            {
                await todoOneRepository.DeleteAsync(TodoOne);
                return true;
            }
            return false;
        }
    }
}
