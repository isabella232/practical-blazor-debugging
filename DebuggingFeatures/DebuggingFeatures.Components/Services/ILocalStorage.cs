﻿using System.Threading.Tasks;

namespace DebuggingFeatures.Components
{
  public interface ILocalStorage
  {
    Task<T> GetProperty<T>(string propName, T defaultValue = default);
    Task<object> SetProperty<T>(string propName, T value);
    Task<object> WatchAsync<T>(T instance) where T : class;
  }
}
