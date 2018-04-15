using System.Data;

namespace uow_generic.Persistence.ORM
{
    public interface IDbProvider
    {
        IDbTransaction InitiateTransaction(IsolationLevel isolationLevel);
        void CommitTransaction(IDbTransaction openTransaction);
        void RollbackTransaction(IDbTransaction openTransaction);


        // long Add(IEntity entity, IDbTransaction openTransaction);
        // long Add(string sp, IEntity entity, IDbTransaction openTransaction);
        // long Add(IEntity entity, string[] ignoreParameters, IDbTransaction openTransaction);
        // void Remove(IEntity entity, IDbTransaction openTransaction);
        // void Execute(string sql, IDbTransaction openTransaction);
        // IEnumerable<T> Get<T>(string query, object args, CommandType type);
        // Dictionary<Type, IEnumerable<object>> QueryMultiple(string sp, object args, CommandType type, IEnumerable<Type> returnTypes);
        // T ExecuteGetSP<T>(string storedProcedure, object args);
    }
}