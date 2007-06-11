using System;
using System.Text;
using Brunet.Dht;

namespace Ipop {
  /// <summary>
  /// A Generic Interface for Dht operations
  /// </summary>
  public interface IDht {
    /// <summary>
    /// Get Dht values
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    DhtGetResult[] Get(string key);

    /// <summary>
    /// Places value in Dht if it is a unique key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="ttl"></param>
    /// <returns>Returns true if successful</returns>
    bool Create(string key, string value, int ttl);

    /// <summary>
    /// Places a value in Dht indexed by its key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="ttl"></param>
    /// <returns>Returns true if successful</returns>
    bool Put(string key, string value, int ttl);
  }
}
