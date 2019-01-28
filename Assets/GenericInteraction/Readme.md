# Generic Interaction

## Interactors

The main way in which input is handled generically is through `Interactor`.  `Interactor` is an abstract class which can be extended to implement different means of interaction.
Interactors must be polled with `<interactor>.IsInteracting()`, which has the same functionality as if you are polling a button directly.

There are example, pre-made Interactors which can be used without modification:

* ```GamepadButton```: takes a KeyCode as the button to check
* ```GamepadJoystick```: uses an axis name and a threshold in which the axis must cross. Direction signifies if it should check in the negative direction.
* ```KeyboardButton```: Uses a button's string name
* ```KeyboardKey```: Uses a buttons KeyCode type
* ```MultiInputInteractor```: Takes a list of interactors and can be set to interact if either **ALL** or **ANY** interactor is interacting.

## Interactables

If you want to have a manager handle inputs and interactions, then you may use `Interactable` on the object which you want to make do something.
`Interactable` objects may be told to do its thing on call of `<interactable>.Interact()`.  `Interactable` must be extended to define a specific implementation.

There are example, pre-made Interactables which can be used without modification:

* ```Hyperlink```: Open the specific url in the system's default browser


# Usage

To get started with generic interaction, drag an `Interactor` implementation onto your object of choice.  Choose the requisite input for the interactor.  Then in your driver script requiring input, add the following bits:

``` 
[SerializeField] 
private Interactor jumpInteractor;
```

and

```
if(jumpInteractor.isInteracting()){
    DoJumpStuff();
}
```

Now you can drop in replacement Interactor scripts or change the specific keys/buttons without having to modify any code!

## Real example

This library is an adaptation from a project I developed for a class.  The project can be found here: [github.com/Vibrant-Media-Lab/Overlay](https://github.com/Vibrant-Media-Lab/Overlay)