using Dapper;
using Microsoft.Extensions.Configuration;
using StoryboardApp.Application.Interfaces;
using StoryboardApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StoryboardApp.Infrastructure.Repositories
{
    public class StoryRepository : IStoryRepository
    {
        private readonly IConfiguration _configuration;

        public StoryRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Story entity)
        {
            entity.DateCreated = DateTime.Now;
            var sql = "INSERT INTO Story (Creator, Assignee, AcceptanceCriteria, Description, StoryState, DateCreated) Values (@Creator, @Assignee, @AcceptanceCriteria, @Description, @StoryState, @DateCreated);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, entity);
                return affectedRow;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Story WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, new { Id = id});
                return affectedRow;
            }
        }

        public async Task<Story> Get(int id)
        {
            var sql = "SELECT * FROM Story WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Story>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Story>> GetAll()
        {
            var sql = "SELECT * FROM Story;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Story>(sql);
                return result;
            }
        }

        public async Task<int> Update(Story entity)
        {
            entity.DateModified = DateTime.Now;
            var sql = "UPDATE Story SET Creator = @Creator, Assignee = @Assignee, AcceptanceCriteria = @AcceptanceCriteria, Description = @Description, StoryState = @StoryState, DateModified = @DateModified WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, entity);
                return affectedRow;
            }
        }
    }
}
