using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    void Subscribe(IObserver _subObserver);
    void Unsubscribe( IObserver _UnsubObserver);
}
