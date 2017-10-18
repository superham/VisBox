<?xml version="1.0" encoding="UTF-8"?>
<MiddleVR>
	<Kernel LogLevel="2" LogInSimulationFolder="0" EnableCrashHandler="0" Version="1.6.0.f4" />
	<DeviceManager>
		<Driver Type="vrDriverDirectInput" />
		<Driver Type="vrDriverVRPN">
			<Tracker Address="DTrack@localhost" ChannelIndex="0" ChannelsNb="2" Name="VRPNTracker2" Right="X" Front="-Z" Up="Y" NeutralPosition="0.000000,0.000000,0.000000" Scale="1" WaitForData="0" />
			<Axis Address="DTrack@localhost" ChannelIndex="0" ChannelsNb="2" Name="VRPNAxis0" />
			<Buttons Address="DTrack@localhost" ChannelIndex="0" ChannelsNb="6" Name="VRPNButtons0" />
		</Driver>
		<Wand Name="Wand0" Driver="0" Axis="VRPNAxis0.Axis" HorizontalAxis="0" HorizontalAxisScale="1" VerticalAxis="1" VerticalAxisScale="1" Buttons="VRPNButtons0.Buttons" Button0="0" Button1="1" Button2="2" Button3="3" Button4="4" Button5="5" />
	</DeviceManager>
	<DisplayManager Fullscreen="0" AlwaysOnTop="1" WindowBorders="0" ShowMouseCursor="1" VSync="0" AntiAliasing="0" ForceHideTaskbar="0" SaveRenderTarget="0" ChangeWorldScale="0" WorldScale="1">
		<Node3D Name="VRSystemCenterNode" Tag="VRSystemCenter" Parent="None" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" />
		<Node3D Name="CenterNode" Parent="VRSystemCenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" />
		<Node3D Name="HandNode" Tag="Hand" Parent="CenterNode" Tracker="VRPNTracker2.Tracker1" IsFiltered="0" Filter="0" UseTrackerX="1" UseTrackerY="1" UseTrackerZ="1" UseTrackerYaw="1" UseTrackerPitch="1" UseTrackerRoll="1" />
		<Node3D Name="HeadNode" Tag="Head" Parent="CenterNode" Tracker="VRPNTracker2.Tracker0" IsFiltered="0" Filter="0" UseTrackerX="1" UseTrackerY="1" UseTrackerZ="1" UseTrackerYaw="1" UseTrackerPitch="1" UseTrackerRoll="1" />
		<CameraStereo Name="CameraCenter" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="1000" Screen="ScreenCenter" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.77778" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraFloor" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="1000" Screen="ScreenFloor" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.77778" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraLeft" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="1000" Screen="ScreenLeft" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.77778" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraRight" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="1000" Screen="ScreenRight" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.77778" InterEyeDistance="0.065" LinkConvergence="1" />
		<Screen Name="ScreenCenter" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,1.143000,1.143000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" Width="4.064" Height="2.286" />
		<Screen Name="ScreenFloor" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="-0.707107,0.000000,0.000000,0.707106" Width="4.064" Height="2.286" />
		<Screen Name="ScreenLeft" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="-2.032000,-0.889000,1.143000" OrientationLocal="0.000000,0.000000,0.707107,0.707106" Width="4.064" Height="2.286" />
		<Screen Name="ScreenRight" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="2.032000,-0.889000,1.143000" OrientationLocal="0.000000,0.000000,-0.707107,0.707106" Width="4.064" Height="2.286" />
		<Viewport Name="Center" Left="0" Top="1080" Width="3840" Height="1080" Camera="CameraCenter" Stereo="1" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseHomography="0" />
		<Viewport Name="Floor" Left="0" Top="2160" Width="3840" Height="1080" Camera="CameraFloor" Stereo="1" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseHomography="0" />
		<Viewport Name="Right" Left="0" Top="3240" Width="3840" Height="1080" Camera="CameraRight" Stereo="1" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseHomography="0" />
		<Viewport Name="Left" Left="0" Top="4320" Width="3840" Height="1080" Camera="CameraLeft" Stereo="1" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseHomography="0" />
	</DisplayManager>
	<ClusterManager NVidiaSwapLock="0" DisableVSyncOnServer="1" ForceOpenGLConversion="0" BigBarrier="0" SimulateClusterLag="0" MultiGPUEnabled="0" ImageDistributionMaxPacketSize="8000" />
</MiddleVR>
