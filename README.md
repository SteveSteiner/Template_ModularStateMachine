# Template_ModularStateMachine
Simple StateMachine for C#, robust and easily-extendable

Create States (e.g. Idle, Walk, Jumping) inheriting the IState interface.

You can then use these States inside of the ModularStateMachine.

To work properly, the ModularStateMachine should "ExecuteStateUpdate" on a regular basis: E.g. in Unity, the Update-Loop is the way to go, but it doesn't have to.
Alternatives in Unity3d can be "InvokeRepeating".
