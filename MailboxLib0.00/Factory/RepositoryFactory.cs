/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   RepositoryFactory.cs
 |  Purpose:    Declares a singleton repository factory.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Factory;
namespace MailboxLib.Factory{
    public sealed class RepositoryFactory : SqlSRepositoryFactory, IRepositoryFactory{
        private static volatile RepositoryFactory _instance;

        private static object _lock = new object();

        private RepositoryFactory() { }

        public static RepositoryFactory Instance{
            get{
                if (_instance == null){
                    lock (_lock){
                        if (_instance == null){
                            _instance = new RepositoryFactory();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
