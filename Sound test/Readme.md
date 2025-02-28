Sound Test Application
Overview
A simple Windows Forms application for playing audio files with basic play/stop functionality.
Features

Play/Stop audio playback using a checkbox button
Supports playing WAV audio files

Technical Details

Developed using C# and .NET Framework 4.0
Created on March 2, 2016
Developed in SharpDevelop

How to Use

Launch the application
Click the "Play" checkbox to start audio playback
Click the checkbox again to stop playback

Important Notes

Requires a WAV file named "Call On Me.wav" in the application directory
Hardcoded file path for an additional WAV file at "c:\mywavfile.wav"

Potential Issues

Hardcoded file paths may cause problems if files are not present
Limited audio playback controls

Development

Namespace: Sound_test
Main form provides a simple interface for audio playback
Uses System.Media.SoundPlayer for audio handling

Requirements

.NET Framework 4.0
Windows operating system
Compatible WAV audio files

Limitations

Only supports WAV file format
No volume or advanced audio controls
Relies on specific file locations
