# How to Position a Radial Menu at Different Screen Locations

This sample demonstrates how to place a Syncfusion MAUI `SfRadialMenu` at different positions on the screen using the `Point` property. The project is a .NET MAUI application that shows a radial menu anchored at predefined layout locations such as top-left, top-right, center, bottom-left, and bottom-right. It is useful for scenarios where you want to open a radial menu from a fixed position in the UI, such as a toolbar, floating action area, or context menu near a specific control or screen corner.

## Overview

In many mobile and desktop applications, actions are grouped into a compact circular menu instead of classic command buttons. The Syncfusion MAUI `SfRadialMenu` is a powerful control that presents commands around a center button in a circular layout. This sample focuses on one common requirement: positioning that menu dynamically based on the available screen or container area.

The app includes a `Picker` control that allows users to change the menu position. The selected option updates the `SfRadialMenu.Point` value in response to the layout size. This is especially helpful when the container resizes based on screen orientation, device family, or window size.

## Key Features

- Positions the radial menu at several predefined screen locations.
- Adjusts the menu location automatically when the layout changes.
- Works with a responsive MAUI layout using `Grid` and `SizeChanged` events.
- Uses a simple and readable sample design for learning and customization.
- Provides a starting point for more advanced contextual menus, editing tools, or floating action patterns.

## Sample Behavior

The sample includes these positions:

- Top Left
- Top Right
- Center
- Bottom Left
- Bottom Right

The logic calculates the safe coordinates based on the `MenuContainer` size and uses the `Point` property to move the radial menu accordingly. The code uses a constant inset value and clamps the values to keep the menu within the available bounds rather than spilling outside the container.

## Project Structure

The main files in this sample are:

- `MainPage.xaml` – defines the UI and radial menu item collection
- `MainPage.xaml.cs` – contains the logic for selecting and updating the radial menu position
- `App.xaml` / `AppShell.xaml` – standard MAUI app startup files
- `MauiProgram.cs` – configures the MAUI application

## Implementation Details

The `MainPage.xaml` layout contains a `Picker` and a `Grid` hosting the `SfRadialMenu`. The `SelectedIndexChanged` event triggers a position update, and the `SizeChanged` event keeps the menu aligned even when the page is resized.

The `UpdateRadialMenuPosition` method computes coordinates using the actual width and height of the layout. It chooses the correct point based on the selected option and writes it to:

```csharp
RadialMenu.Point = selectedPosition switch
{
    "Top Left" => new Point(left, top),
    "Top Right" => new Point(right, top),
    "Bottom Left" => new Point(left, bottom),
    "Bottom Right" => new Point(right, bottom),
    _ => new Point(centerX, centerY)
};
```

This pattern is suitable when you want to keep a floating command menu visually anchored to the screen without hardcoded pixel values that break on different devices.

## Requirements

To run this sample, you need:

- .NET MAUI development environment
- Visual Studio 2022 or a compatible IDE with MAUI workload installed
- A supported Android, iOS, Windows, or Mac Catalyst target
- The Syncfusion MAUI Radial Menu package referenced in the project

## How to Run

1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Set a target platform such as Android or Windows.
4. Build and run the application.
5. Use the position picker to change the radial menu location and observe how the menu moves.

## Use Cases

This approach can be used in:

- Editing tools that appear near a selected element
- Floating context menus for image or document editors
- Action hubs that need to remain anchored to a corner of the screen
- Mobile UIs with quick-access commands and compact gesture-friendly controls

## Why This Matters

A good radial menu placement strategy improves usability by keeping actions close to the user’s expectation and the content they are interacting with. This sample shows how to create a responsive and adaptive menu position without manually recomputing values each time the layout changes. It demonstrates a clear pattern that can be expanded into more advanced menu experiences.

## Conclusion

The sample is a practical example of using `SfRadialMenu` in a .NET MAUI app where the menu needs to appear at different screen locations. It shows how to combine user selection, layout sizing, and a dynamic `Point` update to build a flexible and visually polished interface. Developers can adapt this pattern to suit custom toolbars, contextual menus, or floating command surfaces in real-world applications.

This repository serves as a useful code reference for developers looking to understand how to position a radial menu dynamically and create a better navigation experience in MAUI-based apps.

