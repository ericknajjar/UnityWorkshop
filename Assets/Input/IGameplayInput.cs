

public interface IGameplayInput {

    System.IObservable<float> Movement { get; }
    System.IObservable<UniRx.Unit> Fire { get; }

}
