using MyProject4.Data.Entities;

                namespace MyProject4.Data.Repositories;

                public interface IUserRepository
                {
                    Task<List<User>> GetAllAsync();
                    Task<User?> GetByIdAsync(int id);
                    Task AddAsync(User entity);
                    Task UpdateAsync(User entity);
                    Task DeleteAsync(int id);
                }
                