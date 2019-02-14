# Under Pressure - G6560X IM-QTOF Drift Gas Pressure Tool

Under Pressure is a lightweight application to facilitate monitoring of the drift gas pressures related to the Agilent G6560X IM-QTOF.

## Background

The current method of monitoring and adjusting drift gas pressures can be a little hit and miss. A hyperterminal connection is made and the stream of data in the hyperterminal window is eyeballed.

![A view of the hyperterminal window](https://raw.githubusercontent.com/pageyboy/UnderPressure/master/Readme%20Images/Hyperterminal.png)

More exact measurements can be performed by taking the data offline and exporting to CSV followed by manually parsing the data and creating the statistics or graphs as required.

![Manual creation of statistics and graphs in excel](https://raw.githubusercontent.com/pageyboy/UnderPressure/master/Readme%20Images/ExcelGraph.png)

This is labour intensive and does not allow for an online live view resulting in an iterative process of adjusting and checking.

In response to this and to alleviate frustrations in the lab this tool was developed to allow a live overview of drift gas pressures. Key advantages include:

* No requirement for offline data evaluation
* Standalone tool that can be collecting data whilst MassHunter Data Acquisition is running and acquiring
* Colour coding allows easy determination of the state of drift gas pressures at a glance
* Graphs and all statistics plotted and calculated allowing precise measurement of key data
* Large font allows good visibility even if the PC is at the other end of the adjustment valves

## Getting Started

These instructions will help you get this application set up on the controlling data system connected to your Agilent G6560X IM-QTOF

You can either clone this entire project to your local machine or you can navigate to the following location with the folder structure to download the executable to your local machine or you can click this [link](https://github.com/pageyboy/UnderPressure/raw/master/Under%20Pressure/Under%20Pressure/bin/Debug/Under%20Pressure.exe)

```
Under Pressure\Under Pressure\bin\Debug\
```

The file that is downloaded may be quarantined by your AntiVirus and so you may need to add an exception in to allow this file through.

## Using Under Pressure

<ol type="1">
    <li>Specify desired setpoints on the <b>Setpoints</b> tab. The defaults are the current Agilent recommendations.</li>
    <li>Selecting the serial port and clicking connect will provide pre-requisites for connecting to the instrument via the tool. It describes the use of Hyperterminal to begin relaying the data before closing hyperterminal.</li>
    <li>Click the <b>Start Acquisition</b> button to begin acquiring and storing the instrument output.</li>
    <li>Navigate to the <b>Measure</b> tab to view the output via statistics, graphs or colours. Where the colours denote:
        <ul>
            <li>Green = Good</li>
            <li>Orange = Getting Close</li>
            <li>Red = Much more adjustment required</li>
        </ul>
        Green = Good, Orange = Getting Close, Red = Much more adjustment required.</li>
    <li>The table on the <b>Data</b> tab on the <b>Measure</b> tab can easily be exported into excel by selecting, copying and pasting.</li>
    <li>A <b>leak test</b> has been included for troubleshooting drift gas instability. When the Leak Test checkbox is selected a walk through guide is displayed describing how to set the instrument up to perform the leak test. The set points are automatically updated and the data received is evaluated and colour coded as per the following:</li>
        <ul>
            <li>Green = Acceptable Leak (&#8804; 50 mTorr)</li>
            <li>Orange = Minor Leak or Capillary Cap is fitted (50 - 75 mTorr)</li>
            <li>Red = Major Leak (>75 mTorr)</li>
        </ul>
</ol>

![Leak test on screen information](https://raw.githubusercontent.com/pageyboy/UnderPressure/master/Readme%20Images/LeakTest.png)

**Dummy Instrument**

For testing away from a real instrument and to speed up development a dummy instrument was quickly developed for offline testing. This is available in addition to the tool itself and can be found under [Dummy Serial](https://github.com/pageyboy/UnderPressure/tree/master/DummySerial). It was developed using an [Arduino Uno](https://www.arduino.cc/) and randomly outputs an identical string to the G6560X IM-QTOF albeit more frequently at 40ms intervals rather than 400ms intervals.

To use the Dummy Instrument simply flash the Arduino with the C++ file provided and select the COM port that the Arduino is connected to the PC with. There is no need to set up a hyperterminal if demonstrating with the Dummy Instrument.

## Authors

* **Chris Page** - *Initial Work* - [Pageyboy](https://github.com/pageyboy/)

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/pageyboy/UnderPressure/blob/master/LICENSE) file for details
