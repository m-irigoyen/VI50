<?xml version="1.0" encoding="UTF-8"?>
<MiddleVR>
	<Kernel LogLevel="2" LogInSimulationFolder="0" EnableCrashHandler="0" Version="1.6.1.f6" />
	<DeviceManager>
		<Driver Type="vrDriverDirectInput" />
		<Driver Type="vrDriverVRPN">
			<Tracker Address="Tracker0@localhost" ChannelIndex="0" ChannelsNb="1" Name="VRPNTracker1" Right="X" Front="-Z" Up="Y" NeutralPosition="0.000000,0.000000,0.000000" Scale="1" WaitForData="0" />
		</Driver>
	</DeviceManager>
	<DisplayManager Fullscreen="0" AlwaysOnTop="1" WindowBorders="0" ShowMouseCursor="1" VSync="0" GraphicsRenderer="1" AntiAliasing="0" ForceHideTaskbar="0" SaveRenderTarget="0" ChangeWorldScale="0" WorldScale="1">
		<Node3D Name="VRSystemCenterNode" Tag="VRSystemCenter" Parent="None" Tracker="VRPNTracker1.Tracker0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,-0.442507,0.000000,0.896765" UseTrackerX="0" UseTrackerY="0" UseTrackerZ="0" UseTrackerYaw="0" UseTrackerPitch="0" UseTrackerRoll="1" />
		<Node3D Name="HandNode" Tag="Hand" Parent="VRSystemCenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="-0.000000,-0.000000,0.000000,1.000000" />
		<Viewport Name="Viewport0" Left="0" Top="0" Width="1280" Height="800" Camera="0" Stereo="0" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseHomography="0" />
	</DisplayManager>
	<ClusterManager NVidiaSwapLock="0" DisableVSyncOnServer="1" ForceOpenGLConversion="0" BigBarrier="0" SimulateClusterLag="0" MultiGPUEnabled="0" ImageDistributionMaxPacketSize="8000" ClientConnectionTimeout="60" />
</MiddleVR>
