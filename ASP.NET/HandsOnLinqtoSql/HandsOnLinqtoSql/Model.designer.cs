﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandsOnLinqtoSql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CSCDB")]
	public partial class ModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployeee(Employeee instance);
    partial void UpdateEmployeee(Employeee instance);
    partial void DeleteEmployeee(Employeee instance);
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    #endregion
		
		public ModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CSCDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employeee> Employeees// these are entity sets. used as data source.
		{//properties are created in db context files. 
            //when we drag and drop table, mapping files are created
			get
			{
				return this.GetTable<Employeee>();
			}
		}
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employeee")]
	public partial class Employeee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Eid;
		
		private string _Ename;
		
		private string _Desig;
		
		private System.Nullable<decimal> _Sal;
		
		private System.Nullable<System.DateTime> _hiredate;
		
		private string _Did;
		
		private EntityRef<Dept> _Dept;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEidChanging(int value);
    partial void OnEidChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnDesigChanging(string value);
    partial void OnDesigChanged();
    partial void OnSalChanging(System.Nullable<decimal> value);
    partial void OnSalChanged();
    partial void OnhiredateChanging(System.Nullable<System.DateTime> value);
    partial void OnhiredateChanged();
    partial void OnDidChanging(string value);
    partial void OnDidChanged();
    #endregion
		
		public Employeee()
		{
			this._Dept = default(EntityRef<Dept>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Eid
		{
			get
			{
				return this._Eid;
			}
			set
			{
				if ((this._Eid != value))
				{
					this.OnEidChanging(value);
					this.SendPropertyChanging();
					this._Eid = value;
					this.SendPropertyChanged("Eid");
					this.OnEidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desig", DbType="VarChar(30)")]
		public string Desig
		{
			get
			{
				return this._Desig;
			}
			set
			{
				if ((this._Desig != value))
				{
					this.OnDesigChanging(value);
					this.SendPropertyChanging();
					this._Desig = value;
					this.SendPropertyChanged("Desig");
					this.OnDesigChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sal", DbType="Money")]
		public System.Nullable<decimal> Sal
		{
			get
			{
				return this._Sal;
			}
			set
			{
				if ((this._Sal != value))
				{
					this.OnSalChanging(value);
					this.SendPropertyChanging();
					this._Sal = value;
					this.SendPropertyChanged("Sal");
					this.OnSalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hiredate", DbType="DateTime")]
		public System.Nullable<System.DateTime> hiredate
		{
			get
			{
				return this._hiredate;
			}
			set
			{
				if ((this._hiredate != value))
				{
					this.OnhiredateChanging(value);
					this.SendPropertyChanging();
					this._hiredate = value;
					this.SendPropertyChanged("hiredate");
					this.OnhiredateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Did", DbType="Char(10)")]
		public string Did
		{
			get
			{
				return this._Did;
			}
			set
			{
				if ((this._Did != value))
				{
					if (this._Dept.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDidChanging(value);
					this.SendPropertyChanging();
					this._Did = value;
					this.SendPropertyChanged("Did");
					this.OnDidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Employeee", Storage="_Dept", ThisKey="Did", OtherKey="Did", IsForeignKey=true)]
		public Dept Dept
		{
			get
			{
				return this._Dept.Entity;
			}
			set
			{
				Dept previousValue = this._Dept.Entity;
				if (((previousValue != value) 
							|| (this._Dept.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dept.Entity = null;
						previousValue.Employeees.Remove(this);
					}
					this._Dept.Entity = value;
					if ((value != null))
					{
						value.Employeees.Add(this);
						this._Did = value.Did;
					}
					else
					{
						this._Did = default(string);
					}
					this.SendPropertyChanged("Dept");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dept")]
	public partial class Dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Did;
		
		private string _Dname;
		
		private EntitySet<Employeee> _Employeees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDidChanging(string value);
    partial void OnDidChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    #endregion
		
		public Dept()
		{
			this._Employeees = new EntitySet<Employeee>(new Action<Employeee>(this.attach_Employeees), new Action<Employeee>(this.detach_Employeees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Did", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Did
		{
			get
			{
				return this._Did;
			}
			set
			{
				if ((this._Did != value))
				{
					this.OnDidChanging(value);
					this.SendPropertyChanging();
					this._Did = value;
					this.SendPropertyChanged("Did");
					this.OnDidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Employeee", Storage="_Employeees", ThisKey="Did", OtherKey="Did")]
		public EntitySet<Employeee> Employeees
		{
			get
			{
				return this._Employeees;
			}
			set
			{
				this._Employeees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employeees(Employeee entity)
		{
			this.SendPropertyChanging();
			entity.Dept = this;
		}
		
		private void detach_Employeees(Employeee entity)
		{
			this.SendPropertyChanging();
			entity.Dept = null;
		}
	}
}
#pragma warning restore 1591
