/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSRepositoryFactory.cs
 |  Purpose:    Declares a repository factory which constructs entity collections.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System;
using MailboxLib.Base;
using MailboxLib.Data.Repositories;
using Repository.Data;
using Repository.Factory;
using Repository.Helpers;
namespace MailboxLib.Factory{
    public class SqlSRepositoryFactory: IRepositoryFactory{
        public IDataRepository<T> Construct<T>(params object[] args) where T : IDataUnit{
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Email))){
                //In the hierarchy tree of emails, a repository of it is built.
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSEmailRepository), args);
            }
            return null;
        }
    }
}
