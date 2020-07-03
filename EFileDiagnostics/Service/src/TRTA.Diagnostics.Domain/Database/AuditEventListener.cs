using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace TRTA.Diagnostics.Domain.Database
{
    public class AuditEventListener : IPreUpdateEventListener, IPreInsertEventListener
    {
        public bool OnPreUpdate(PreUpdateEvent @event)
        {
            var auditable = @event.Entity as IAuditable;
            if (auditable == null)
            {
                return false;
            }

            var now = DateTime.Now;

            SetAuditableProperty(@event.Persister, @event.State, "DateModified", now);

            auditable.DateModified = now;

            return false;
        }

        public Task<bool> OnPreUpdateAsync(PreUpdateEvent @event, CancellationToken cancellationToken)
        {
            var auditable = @event.Entity as IAuditable;
            if (auditable == null)
            {
                return Task.FromResult<bool>(false);
            }
            var now = DateTime.Now;
            SetAuditableProperty(@event.Persister, @event.State, "DateModified", now);
            auditable.DateModified = now;
            return Task.FromResult<bool>(false);
        }

        bool IPreInsertEventListener.OnPreInsert(PreInsertEvent @event)
        {
            var auditable = @event.Entity as IAuditable;
            if (auditable == null)
            {
                return false;
            }

            var now = DateTime.Now;

            SetAuditableProperty(@event.Persister, @event.State, "DateModified", now);

            auditable.DateModified = now;

            return false;
        }

        Task<bool> IPreInsertEventListener.OnPreInsertAsync(PreInsertEvent @event, CancellationToken cancellationToken)
        {
            var auditable = @event.Entity as IAuditable;
            if (auditable == null)
            {
                return Task.FromResult<bool>(false);
            }
            var now = DateTime.Now;
            SetAuditableProperty(@event.Persister, @event.State, "DateModified", now);
            auditable.DateModified = now;
            return Task.FromResult<bool>(false);
        }

        protected virtual void SetAuditableProperty(IEntityPersister persister, object[] state, string propertyName, object value)
        {
            var index = Array.IndexOf(persister.PropertyNames, propertyName);
            if (index == -1)
                return;
            state[index] = value;
        }
    }

}
