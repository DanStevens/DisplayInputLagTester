# DisplayInputLagTester

A simple utility app for measuring relative display input lag between two displays connected to the same Windows PC.

## Why?

Many HD and 4K TVs using image processing to improve video quality, which can increase input lag between
the video source (e.g. a PC) the display. One approach to measuring input lag is to connect two displays to
a Windows PC set to 'Duplicate' mode in the Display settings, followed by taking a photograph of both displays
showing a running stopwatch. However, in my case, I wanted to measure input lag of a TV with HDR enabled and Windows
doesn't allow you to enable HDR when with 'Duplicate' display mode is enabled, presumably because one of
the displays doesn't support HDR. To work around this, I create this app that displays two windows each
showing the same stopwatch. Now, using the 'Extend' display mode, I could position one window on each
display and measure the relative input lag that way.

## How to use this app

Connect the two displays which you wish to compare to the same PC, for example, a high quality computer
monitor and an 4K TV. Position both displays so they are within view of each other, since you will be
taking a photograph of them both with a camera.

When launched, this .NET 5 app creates two windows, of which each displays a synchronised stopwatch.
Place one window on each display which you wish to compare. Click the 'Start' button and the
stopwatches of both windows will begin counting in sync, with the larger font showing the milliseconds.

Now, with the stopwatches being displayed on both displays, take a single photograph of both display
in shot, ensuring the milliseconds count is large enough to be readable (resize the window if it's 
too small).

To calculate the relative input lag of the displays, take the photograph and compare the times shown
in each display subtract the times shown on each window. The smaller time is the monitor with the
greater input lag relative to the other.

## Tips

  - Ideally one of the displays should be a computer monitor without video processing to get the best results
  - If you're having trouble reading the millisecond count, it might be due to long exposure on
    the camera. Try any of the following:
      - Increase ambient light
      - Enable flash
      - Set a fixed shutter speed that's faster than your monitor refesh rate, if supported by the camera
      - Reduce exposure or increase ISO, if supported by the camera.
      - Try a better camera - a dedicated camera will more likely give a better image than a smart phone
        camera, for example.