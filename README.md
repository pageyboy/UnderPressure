# Under Pressure - G6560X IM-QTOF Drift Gas Pressure Tool

Under Pressure is a lightweight application to facilitate monitoring of the drift gas pressures related to the Agilent G6560X IM-QTOF.

---

## Background

The current method of monitoring drift gas pressures is a little hit and miss. A hyperterminal connection is made and the stream of data in the hyperterminal window is eyeballed.

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

---

## Getting Started

These instructions will help you get this application set up on the controlling data system connected to your Agilent G6560X IM-QTOF

You can either clone this entire project to your local machine or you can navigate to the following location with the folder structure to download the executable to your local machine or you can click this [link](https://github.com/pageyboy/UnderPressure/raw/master/Under%20Pressure/Under%20Pressure/bin/Debug/Under%20Pressure.exe)

```
Under Pressure\Under Pressure\bin\Debug\
```

The file that is downloaded may be quarantined by your AntiVirus and so you may need to add an exception in to allow this file through.

---

## Using Under Pressure

1. Specify desired setpoints on the **setpoints** tab. The defaults are the current Agilent recommendations.
2. Selecting the serial port and clicking connect will provide pre-requisites for connecting to the instrument via the tool. It describes the use of Hyperterminal to begin relaying the data before closing hyperterminal.
3. Click the **Start Acquisition** button to begin acquiring and storing the instrument output.
4. Navigate to the **Measure** tab to view the output via statistics, graphs or colours. Green = Good, Orange = Getting Close, Red = Much more adjustment required.
5. The table on the **Data** tab on the **Measure** tab can easily be exported into excel by selecting, copying and pasting.
6. A **leak test** has been included for troubleshooting drift gas instability. When the Leak Test checkbox is selected a walk through guide is displayed describing how to set the instrument up to perform the leak test. The set points are automatically updated and the data received is evaluated and colour coded as per the following:
* Green = Acceptable Leak (&#8804; 50 mTorr)
* Orange = Minor Leak or Capillary Cap is fitted (50 - 75 mTorr)
* Red = Major Leak (>75 mTorr).

![Leak test on screen information](https://raw.githubusercontent.com/pageyboy/UnderPressure/master/Readme%20Images/LeakTest.png)
