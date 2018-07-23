# TimelineControllerStateMachine
a simple state machine for the unity timeline


Simple State Machine using Timeline Controller

Lumberjack uses traditional animator and the different states will loop through unless you disable it.
this seems to be overwritten when timeline is used


in TimelineController script we use the playableDirector to control the timeline. The timeline is mapped to the lumberjack.
The timeline is made up of two of the lumberjacks animations.

if there is no _currentState the animation plays the idle state. the idle state is set to loop.

state is changed to swing when the w key is pressed.

after the swing, the character returns to the idle state.

