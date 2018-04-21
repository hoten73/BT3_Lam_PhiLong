﻿using System;
using System.Collections.Generic;
using Autofac;
using System.Text;
using SmartHotel2.ViewModels;
using SmartHotel2.Services.Navigation;

namespace SmartHotel2
{
    public class ServiceLocator
    {
        private IContainer _container;
        private readonly ContainerBuilder _containerBuilder;

        public static ServiceLocator Instance { get; }

        static ServiceLocator()
        {
            Instance = new ServiceLocator();
        }

        public ServiceLocator()
        {
            _containerBuilder = new ContainerBuilder();
            RegisterInstance<INavigationService, NavigationService>();
            _containerBuilder.RegisterType<LoginViewModel>();
            _containerBuilder.RegisterType<MainViewModel>();
            _containerBuilder.RegisterType<HomeViewModel>();
        }

        public void Register<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>();
        }

        public void RegisterInstance<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>().SingleInstance();
        }

        public T Resolve<T>()
        {    
            return _container.Resolve<T>();
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }
        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
