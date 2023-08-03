using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DIrTest
{
    [Test]
    public void DIrTestSimplePasses()
    {
        Assert.AreEqual(Move.Right, Vector3.left);
    }
}
