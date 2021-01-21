using System;

namespace Zeats.Legacy.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}