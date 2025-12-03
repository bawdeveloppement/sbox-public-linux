using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbox.Engine.Emulation.Common;

namespace Sbox.Engine.Emulation.Tests.Common;

/// <summary>
/// Tests pour HandleManager centralisé.
/// </summary>
[TestClass]
public class HandleManagerTests
{
    [TestMethod]
    public void Register_ShouldReturnUniqueHandle()
    {
        var obj1 = new object();
        var obj2 = new object();
        
        int handle1 = HandleManager.Register(obj1);
        int handle2 = HandleManager.Register(obj2);
        
        Assert.AreNotEqual(handle1, handle2);
        Assert.IsTrue(handle1 >= 1000);
        Assert.IsTrue(handle2 >= 1000);
    }
    
    [TestMethod]
    public void Get_ShouldReturnRegisteredObject()
    {
        var obj = new object();
        int handle = HandleManager.Register(obj);
        
        var retrieved = HandleManager.Get<object>(handle);
        
        Assert.AreEqual(obj, retrieved);
    }
    
    [TestMethod]
    public void Get_ShouldReturnNullForInvalidHandle()
    {
        var result = HandleManager.Get<object>(9999);
        
        Assert.IsNull(result);
    }
    
    [TestMethod]
    public void Unregister_ShouldRemoveObject()
    {
        var obj = new object();
        int handle = HandleManager.Register(obj);
        
        HandleManager.Unregister(handle);
        
        var retrieved = HandleManager.Get<object>(handle);
        Assert.IsNull(retrieved);
    }
    
    [TestMethod]
    public void Exists_ShouldReturnTrueForValidHandle()
    {
        var obj = new object();
        int handle = HandleManager.Register(obj);
        
        bool exists = HandleManager.Exists(handle);
        
        Assert.IsTrue(exists);
    }
    
    [TestMethod]
    public void Exists_ShouldReturnFalseForInvalidHandle()
    {
        bool exists = HandleManager.Exists(9999);
        
        Assert.IsFalse(exists);
    }
}

