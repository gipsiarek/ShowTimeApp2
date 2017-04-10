using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp.Model.Abstract
{
    [Serializable()]
    public abstract class AbstractViewModel : INotifyPropertyChanged
    {

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        //}

        //protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        //{
        //    var handler = this.PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, e);
        //    }
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        protected string GetPropertyName<TProperty>(Expression<Func<TProperty>> property)
        {
            var lambda = (LambdaExpression)property;

            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
                memberExpression = (MemberExpression)lambda.Body;

            return memberExpression.Member.Name;
        }

        public void OnPropertyChanged<TProperty>(Expression<Func<TProperty>> property)
        {
            OnPropertyChanged(GetPropertyName(property));
        }
    }
}
