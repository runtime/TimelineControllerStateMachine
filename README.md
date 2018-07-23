# TimelineControllerStateMachine
a simple state machine for the unity timeline

character will idle until W key is pressed.


Simple State Machine using Timeline Controller

this Lumberjack uses traditional unity animator and he will loop through the existing states unless you disable the animator
this also seems to be overwritten when timeline is used

in TimelineController script I use the playableDirector to control the timeline. The timeline is mapped to the lumberjack.
The timeline is made up of two of the lumberjacks animations. idle and lumber (swing)

if there is no _currentState the animation plays the idle state and idle becomes the current state4.  the idle state is set to loop based on a conditional statement

state is changed to swing when the w key is pressed and the state changes to 'swing"

after the swing, the character returns to the idle state and the state changes to 'idle'

this file was commited to a public github repository to test github with unity.

a unity specific git ignore file is being used.

.DS_store was -rm cached

