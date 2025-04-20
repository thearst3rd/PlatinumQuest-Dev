<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2025/04/13 17:25:14">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="15">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="12" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="16" dl="0" group="-1" locked="0" />
        <SceneShape id="12" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="19" dl="0" group="-1" locked="0" />
        <SceneShape id="14" type="1" entityID="20" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="21">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -112 36" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -112 42" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="4 -112 36" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-2 -42 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 -42 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="-2 -42 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 -36 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-2 -36 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 -36 55" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 -25 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="-2 -25 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 -25 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="-3 -21 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 -21 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="path_node" gametype="Torque" isPointEntity="1" origin="-3 -21 57" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="419">
                    <Brush id="0" owner="0" type="0" pos="0 0 -9" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 16 1" />
                            <Vertex pos="16 16 -1" />
                            <Vertex pos="16 -16 1" />
                            <Vertex pos="16 -16 -1" />
                            <Vertex pos="-16 16 1" />
                            <Vertex pos="-16 16 -1" />
                            <Vertex pos="-16 -16 1" />
                            <Vertex pos="-16 -16 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -16" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-15 0 0" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 8" />
                            <Vertex pos="1 16 -8" />
                            <Vertex pos="1 -16 8" />
                            <Vertex pos="1 -16 -8" />
                            <Vertex pos="-1 16 8" />
                            <Vertex pos="-1 16 -8" />
                            <Vertex pos="-1 -16 8" />
                            <Vertex pos="-1 -16 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="15 0 18" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 0 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 26" />
                            <Vertex pos="1 16 -26" />
                            <Vertex pos="1 -16 26" />
                            <Vertex pos="1 -16 -26" />
                            <Vertex pos="-1 16 26" />
                            <Vertex pos="-1 16 -26" />
                            <Vertex pos="-1 -16 26" />
                            <Vertex pos="-1 -16 -26" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="2 -15 10" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -15 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 18" />
                            <Vertex pos="12 1 -18" />
                            <Vertex pos="12 -1 18" />
                            <Vertex pos="12 -1 -18" />
                            <Vertex pos="-12 1 18" />
                            <Vertex pos="-12 1 -18" />
                            <Vertex pos="-12 -1 18" />
                            <Vertex pos="-12 -1 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3328 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3072 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank4" texgens="1 0 0 -3072 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 3328 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-4 15 0" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 15 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 8" />
                            <Vertex pos="6 1 -8" />
                            <Vertex pos="6 -1 8" />
                            <Vertex pos="6 -1 -8" />
                            <Vertex pos="-6 1 8" />
                            <Vertex pos="-6 1 -8" />
                            <Vertex pos="-6 -1 8" />
                            <Vertex pos="-6 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-12 14 -3" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 14 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 5" />
                            <Vertex pos="2 2 -5" />
                            <Vertex pos="2 -1.5 5" />
                            <Vertex pos="2 -1.5 -5" />
                            <Vertex pos="-2 2 5" />
                            <Vertex pos="-2 2 -5" />
                            <Vertex pos="-2 -2 5" />
                            <Vertex pos="-2 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.124035 -0.992278 0 -1.73649" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-13 18 -4" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 18 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 6" />
                            <Vertex pos="3 2 -6" />
                            <Vertex pos="3 -2 6" />
                            <Vertex pos="3 -2 -6" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-2 2 -6" />
                            <Vertex pos="-3 -2 6" />
                            <Vertex pos="-3 -2 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -2.42536" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-13 22 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 22 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 5.5" />
                            <Vertex pos="2 1 -5.5" />
                            <Vertex pos="3 -2 5.5" />
                            <Vertex pos="3 -2 -5.5" />
                            <Vertex pos="-0.499999 1.5 5.5" />
                            <Vertex pos="-0.499999 1.5 -5.5" />
                            <Vertex pos="-2 -2 5.5" />
                            <Vertex pos="-2 -2 -5.5" />
                        </Vertices>
                        <Face id="0" plane="0.948683 0.316228 0 -2.21359" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.919145 0.39392 0 -1.05045" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.196116 0.980581 -0 -1.37281" album="" material="bm_grid_blank4" texgens="-1 0 0 204.8 0 0 -1 -192 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -5.5" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-12 9 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 9 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 4.75" />
                            <Vertex pos="2 1 -5.25" />
                            <Vertex pos="2 -1 5.25" />
                            <Vertex pos="2 -1 -5.25" />
                            <Vertex pos="-2 1 4.75" />
                            <Vertex pos="-2 1 -5.25" />
                            <Vertex pos="-2 -1 5.25" />
                            <Vertex pos="-2 -1 -5.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -4.85071" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-12 7 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 7 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 5.25" />
                            <Vertex pos="2 1 -5.25" />
                            <Vertex pos="2 -2 5.25" />
                            <Vertex pos="2 -2 -5.25" />
                            <Vertex pos="-2 1 5.25" />
                            <Vertex pos="-2 1 -5.25" />
                            <Vertex pos="-2 -1 5.25" />
                            <Vertex pos="-2 -1 -5.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.242536 -0.970142 -0 -1.45521" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.25" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-12 4 -2" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 4 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 6" />
                            <Vertex pos="2 1 -6" />
                            <Vertex pos="2 -2 6" />
                            <Vertex pos="2 -2 -6" />
                            <Vertex pos="-2 2 4.5" />
                            <Vertex pos="-2 2 -6" />
                            <Vertex pos="-2 -1.5 4.5" />
                            <Vertex pos="-2 -1.5 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.242536 0.970142 -0 -1.45521" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.124035 -0.992278 -0 -1.73649" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -4.91573" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-11 -4.5 -2" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -4.5 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.5 6" />
                            <Vertex pos="1 2.5 -6" />
                            <Vertex pos="3 -1.5 6" />
                            <Vertex pos="3 -1.5 -6" />
                            <Vertex pos="-3 2.5 6" />
                            <Vertex pos="-3 2.5 -6" />
                            <Vertex pos="-3 -2.5 6" />
                            <Vertex pos="-3 -2.5 -6" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -2.01246" album="" material="bm_grid_blank4" texgens="0 1 0 -2112 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.164399 -0.986394 0 -1.97279" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-12 -12 -1" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -12 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7" />
                            <Vertex pos="2 2 -7" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -7" />
                            <Vertex pos="-2 2 7" />
                            <Vertex pos="-2 2 -7" />
                            <Vertex pos="-2 -2 7" />
                            <Vertex pos="-2 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-11 -8 -1" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -8 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 5" />
                            <Vertex pos="3 2 -7" />
                            <Vertex pos="3 -2 5" />
                            <Vertex pos="3 -2 -7" />
                            <Vertex pos="-3 1 7" />
                            <Vertex pos="-3 1 -7" />
                            <Vertex pos="-3 -2 7" />
                            <Vertex pos="-3 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.164399 0.986394 0 -1.47959" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -5.6921" album="" material="bm_tile10_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-12 0.25 -2" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 0.25 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.75 6" />
                            <Vertex pos="2 1.75 -6" />
                            <Vertex pos="2 -2.25 6" />
                            <Vertex pos="2 -2.25 -6" />
                            <Vertex pos="-2 2.25 6" />
                            <Vertex pos="-2 2.25 -6" />
                            <Vertex pos="-2 -2.25 6" />
                            <Vertex pos="-2 -2.25 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2016 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2272 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.124035 0.992278 -0 -1.98456" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -6" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-9 -12 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -12 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7.5" />
                            <Vertex pos="1 2 -7.5" />
                            <Vertex pos="1 -2 7.5" />
                            <Vertex pos="1 -2 -7.5" />
                            <Vertex pos="-1 2 6.5" />
                            <Vertex pos="-1 2 -7.5" />
                            <Vertex pos="-1 -2 6.5" />
                            <Vertex pos="-1 -2 -7.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -6.26099" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-5 -12 -0.249999" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -12 0 0 1 -0.249999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7.75" />
                            <Vertex pos="1 2 -7.75" />
                            <Vertex pos="1 -2 7.75" />
                            <Vertex pos="1 -2 -7.75" />
                            <Vertex pos="-1 2 7.25" />
                            <Vertex pos="-1 2 -7.75" />
                            <Vertex pos="-1 -2 7.25" />
                            <Vertex pos="-1 -2 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -7.27607" album="" material="bm_friction_mud" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-3 -12 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -12 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.5 7.75" />
                            <Vertex pos="1 1.5 -7.75" />
                            <Vertex pos="1 -2 7.75" />
                            <Vertex pos="1 -2 -7.75" />
                            <Vertex pos="-1 2 7.75" />
                            <Vertex pos="-1 2 -7.75" />
                            <Vertex pos="-1 -2 7.75" />
                            <Vertex pos="-1 -2 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.242536 0.970142 -0 -1.69775" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -7.75" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="1 -13 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -13 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7.75" />
                            <Vertex pos="1 1 -7.75" />
                            <Vertex pos="1 -1 7.75" />
                            <Vertex pos="1 -1 -7.75" />
                            <Vertex pos="-1 1 7.75" />
                            <Vertex pos="-1 1 -7.75" />
                            <Vertex pos="-1 -1 7.75" />
                            <Vertex pos="-1 -1 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="3 -12.25 0" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -12.25 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.75 8" />
                            <Vertex pos="1 1.75 -8" />
                            <Vertex pos="1 -1.75 8" />
                            <Vertex pos="1 -1.75 -8" />
                            <Vertex pos="-1 0.249998 7.5" />
                            <Vertex pos="-1 0.249999 -8" />
                            <Vertex pos="-1 -1.75 7.5" />
                            <Vertex pos="-1 -1.75 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2080 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2336 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.6 0.8 0 -0.799999" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -7.51861" album="" material="bm_friction_mud" texgens="1 0 0 -256 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2336 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="5 -12 0" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -12 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 8" />
                            <Vertex pos="1 2 -8" />
                            <Vertex pos="1 -2 8" />
                            <Vertex pos="1 -2 -8" />
                            <Vertex pos="-1 1.5 8" />
                            <Vertex pos="-1 1.5 -8" />
                            <Vertex pos="-1 -2 8" />
                            <Vertex pos="-1 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 -1.69775" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="11 -12 1" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -12 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 9" />
                            <Vertex pos="3 2 -9" />
                            <Vertex pos="3 -2 9" />
                            <Vertex pos="3 -2 -9" />
                            <Vertex pos="-3 2 7" />
                            <Vertex pos="-3 2 -9" />
                            <Vertex pos="-3 -2 7" />
                            <Vertex pos="-3 -2 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 -7.58947" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="12 -9 1.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -9 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 9.25" />
                            <Vertex pos="2 1 -9.25" />
                            <Vertex pos="2 -1 8.75" />
                            <Vertex pos="2 -1 -9.25" />
                            <Vertex pos="-2 1 9.25" />
                            <Vertex pos="-2 1 -9.25" />
                            <Vertex pos="-2 -1 8.75" />
                            <Vertex pos="-2 -1 -9.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -8.73128" album="" material="bm_friction_mud" texgens="1 0 0 -512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="12 -7 1.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -7 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 9.25" />
                            <Vertex pos="2 1 -9.25" />
                            <Vertex pos="2 -1 9.25" />
                            <Vertex pos="2 -1 -9.25" />
                            <Vertex pos="-0.999999 1 9.25" />
                            <Vertex pos="-0.999999 1 -9.25" />
                            <Vertex pos="-2 -1 9.25" />
                            <Vertex pos="-2 -1 -9.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -1.34164" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -928 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.25" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="13 -3 1" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -3 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 9" />
                            <Vertex pos="1 1 -9" />
                            <Vertex pos="1 -1 9" />
                            <Vertex pos="1 -1 -9" />
                            <Vertex pos="-1 1 8.5" />
                            <Vertex pos="-1 1 -9" />
                            <Vertex pos="-1 -1 8.5" />
                            <Vertex pos="-1 -1 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -8.48875" album="" material="bm_friction_mud" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="12 -1 0.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -1 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 8.75" />
                            <Vertex pos="2 1 -8.75" />
                            <Vertex pos="2 -1 8.75" />
                            <Vertex pos="2 -1 -8.75" />
                            <Vertex pos="-2 1 8.75" />
                            <Vertex pos="-2 1 -8.75" />
                            <Vertex pos="0 -1 8.75" />
                            <Vertex pos="0 -1 -8.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.707107" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="12 1 0.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 1 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 8.75" />
                            <Vertex pos="2 1 -8.75" />
                            <Vertex pos="2 -1 8.75" />
                            <Vertex pos="2 -1 -8.75" />
                            <Vertex pos="-2 1 8.75" />
                            <Vertex pos="-2 1 -8.75" />
                            <Vertex pos="-2 -1 8.75" />
                            <Vertex pos="-2 -1 -8.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="11 6 0.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 6 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7.75" />
                            <Vertex pos="1 2 -8.75" />
                            <Vertex pos="1 -2 7.75" />
                            <Vertex pos="1 -2 -8.75" />
                            <Vertex pos="-1 1 8.75" />
                            <Vertex pos="-1 1 -8.75" />
                            <Vertex pos="-1 -2 8.75" />
                            <Vertex pos="-1 -2 -8.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -1.34164" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -7.37902" album="" material="bm_friction_mud" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="13 8 0.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 8 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 8.25" />
                            <Vertex pos="1 2 -8.25" />
                            <Vertex pos="1 -2 8.25" />
                            <Vertex pos="1 -2 -8.25" />
                            <Vertex pos="-1 2 8.25" />
                            <Vertex pos="-1 2 -8.25" />
                            <Vertex pos="-1 -2 8.25" />
                            <Vertex pos="-1 -2 -8.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8.25" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="12 12 4.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 12 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3.75" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 -2 4.25" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="-2 2 3.75" />
                            <Vertex pos="-2 2 1.75" />
                            <Vertex pos="-9.53674e-007 -2 4.25" />
                            <Vertex pos="-9.53674e-007 -2 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447213 0 -0.894428" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.124035 0.992278 -3.96911" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="12 15 0" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 15 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 8" />
                            <Vertex pos="2 1 -8" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -8" />
                            <Vertex pos="-2 1 8" />
                            <Vertex pos="-2 1 -8" />
                            <Vertex pos="-2 -1 8" />
                            <Vertex pos="-2 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="13 20 -1" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 20 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 9" />
                            <Vertex pos="3 4 -9" />
                            <Vertex pos="3 -4 9" />
                            <Vertex pos="3 -4 -9" />
                            <Vertex pos="-3 2 9" />
                            <Vertex pos="-3 2 -9" />
                            <Vertex pos="-3 -4 9" />
                            <Vertex pos="-3 -4 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.316228 0.948683 0 -2.84605" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="18 20 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 20 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.5" />
                            <Vertex pos="2 2 -9.5" />
                            <Vertex pos="2 -2 9.5" />
                            <Vertex pos="2 -2 -9.5" />
                            <Vertex pos="-2 4 9.5" />
                            <Vertex pos="-2 4 -9.5" />
                            <Vertex pos="-2 -4 9.5" />
                            <Vertex pos="-2 -4 -9.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -2.68328" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.68328" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -9.5" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -9.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="8 20 6.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 20 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2 -2 16.75" />
                            <Vertex pos="2 -2 -16.75" />
                            <Vertex pos="-2 2 16.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-1.5 -2.5 16.75" />
                            <Vertex pos="-1.5 -2.5 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.993884 -0.110432 0 -1.7669" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.141421 -0.989949 0 -2.26274" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="22 20 1.5" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 20 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7.5" />
                            <Vertex pos="2 2 2.5" />
                            <Vertex pos="2 -2 7.5" />
                            <Vertex pos="2 -2 2.5" />
                            <Vertex pos="-2 2 7.5" />
                            <Vertex pos="-2 2 -7.5" />
                            <Vertex pos="-2 -2 7.5" />
                            <Vertex pos="-2 -2 -7.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -2816 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 2816 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.5" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.928477 0 -0.371391 -0.928477" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -384 0 -1 0 256 0 0.1 0.25" texRot="0" texScale="0.1 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="25 20 6.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 20 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2.75" />
                            <Vertex pos="1 2 0.750001" />
                            <Vertex pos="1 -2 2.75" />
                            <Vertex pos="1 -2 0.750001" />
                            <Vertex pos="-1 2 2.25" />
                            <Vertex pos="-1 2 -2.75" />
                            <Vertex pos="-1 -2 2.25" />
                            <Vertex pos="-1 -2 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -3200 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 3200 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -2.42536" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.868243 0 -0.496139 -0.496139" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 256 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="27 20 8.875" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 20 0 0 1 8.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.375" />
                            <Vertex pos="1 2 0.374999" />
                            <Vertex pos="1 -2 1.375" />
                            <Vertex pos="1 -2 0.374999" />
                            <Vertex pos="-1 2 0.625" />
                            <Vertex pos="-1 2 -1.375" />
                            <Vertex pos="-1 -2 0.625" />
                            <Vertex pos="-1 -2 -1.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1904 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1904 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -3456 0 0 -1 -1136 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 3456 0 0 -1 -1136 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.936329" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.658504 0 -0.752577 -0.376289" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="29 20 10.25" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 20 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 0" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 0" />
                            <Vertex pos="-1 2 0" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 0" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -3712 0 0 -1 -1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 3712 0 0 -1 -1312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447214" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="31 20 11.375" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 20 0 0 1 11.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.125" />
                            <Vertex pos="1 2 0.125" />
                            <Vertex pos="1 -2 1.125" />
                            <Vertex pos="1 -2 0.125" />
                            <Vertex pos="-1 2 -0.125001" />
                            <Vertex pos="-1 2 -1.125" />
                            <Vertex pos="-1 -2 -0.125001" />
                            <Vertex pos="-1 -2 -1.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -3968 0 0 -1 -1456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 3968 0 0 -1 -1456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.529999 0 0.847998 -0.423999" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="33 20 12.5" rot="1 0 0 0" scale="" transform="1 0 0 33 0 1 0 20 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 0" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 0" />
                            <Vertex pos="-1 2 0" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 0" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -4224 0 0 -1 -1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 4224 0 0 -1 -1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447214" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="35 20 13.375" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 20 0 0 1 13.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.875" />
                            <Vertex pos="1 2 -0.125" />
                            <Vertex pos="1 -2 0.875" />
                            <Vertex pos="1 -2 -0.125" />
                            <Vertex pos="-1 2 0.125" />
                            <Vertex pos="-1 2 -0.875" />
                            <Vertex pos="-1 -2 0.125" />
                            <Vertex pos="-1 -2 -0.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -4480 0 0 -1 -1712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 4480 0 0 -1 -1712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.468165" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.468165" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="37 20 14" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 20 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.75" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.75" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -4736 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 4736 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485071" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="39 20 14.375" rot="1 0 0 0" scale="" transform="1 0 0 39 0 1 0 20 0 0 1 14.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.625" />
                            <Vertex pos="1 2 -0.375001" />
                            <Vertex pos="1 -2 0.625" />
                            <Vertex pos="1 -2 -0.375001" />
                            <Vertex pos="-1 2 0.375" />
                            <Vertex pos="-1 2 -0.625001" />
                            <Vertex pos="-1 -2 0.375" />
                            <Vertex pos="-1 -2 -0.625001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 -4992 0 0 -1 -1840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 4992 0 0 -1 -1840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -0.496139" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.49614" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="43 20 2.5" rot="1 0 0 0" scale="" transform="1 0 0 43 0 1 0 20 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 12.5" />
                            <Vertex pos="3 2 -12.5" />
                            <Vertex pos="3 -2 12.5" />
                            <Vertex pos="3 -2 -12.5" />
                            <Vertex pos="-3 2 12.5" />
                            <Vertex pos="-3 2 -12.5" />
                            <Vertex pos="-3 -2 12.5" />
                            <Vertex pos="-3 -2 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="27 20 14.75" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 20 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485071" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="25 20 15.375" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 20 0 0 1 15.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.125001" />
                            <Vertex pos="1 2 -0.875001" />
                            <Vertex pos="1 -2 0.125001" />
                            <Vertex pos="1 -2 -0.875001" />
                            <Vertex pos="-1 2 0.875" />
                            <Vertex pos="-1 2 -0.125001" />
                            <Vertex pos="-1 -2 0.875" />
                            <Vertex pos="-1 -2 -0.125001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1968 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1968 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -0.468165" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -0.468166" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="23 20 16.25" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 20 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.90735e-006" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 1.90735e-006" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1.90735e-006" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1.90735e-006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447213 0 0.894428 -0.447215" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447213 0 -0.894428 -0.447215" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="21 20 17.375" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 20 0 0 1 17.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -0.125" />
                            <Vertex pos="1 2 -1.125" />
                            <Vertex pos="1 -2 -0.125" />
                            <Vertex pos="1 -2 -1.125" />
                            <Vertex pos="-1 2 1.125" />
                            <Vertex pos="-1 2 0.125" />
                            <Vertex pos="-1 -2 1.125" />
                            <Vertex pos="-1 -2 0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 0 0 -1 288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.529999 0 0.847998 -0.423999" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="19 20 18.75" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 20 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 2 -1.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="1 -2 -1.25" />
                            <Vertex pos="-1 2 1.25" />
                            <Vertex pos="-1 2 0.250002" />
                            <Vertex pos="-1 -2 1.25" />
                            <Vertex pos="-1 -2 0.250002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2400 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2400 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.75 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.75 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.6 0 0.8 -0.4" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.600001 0 -0.8 -0.399999" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="17 20 20.125" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 20 0 0 1 20.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -0.125002" />
                            <Vertex pos="1 2 -1.125" />
                            <Vertex pos="1 -2 -0.125002" />
                            <Vertex pos="1 -2 -1.125" />
                            <Vertex pos="-1 2 1.125" />
                            <Vertex pos="-1 2 0.125" />
                            <Vertex pos="-1 -2 1.125" />
                            <Vertex pos="-1 -2 0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.53 0 0.847998 -0.423998" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="15 20 21.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 20 0 0 1 21.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -1.90735e-006" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 -1.90735e-006" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 0.999998" />
                            <Vertex pos="-1 2 0" />
                            <Vertex pos="-1 -2 0.999998" />
                            <Vertex pos="-1 -2 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2720 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2720 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.447212" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="13 20 22.125" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 20 0 0 1 22.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.125" />
                            <Vertex pos="1 2 -0.875" />
                            <Vertex pos="1 -2 0.125" />
                            <Vertex pos="1 -2 -0.875" />
                            <Vertex pos="-1 2 0.875" />
                            <Vertex pos="-1 2 -0.125" />
                            <Vertex pos="-1 -2 0.875" />
                            <Vertex pos="-1 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -0.468165" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -0.468165" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="11 20 22.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 20 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2912 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485071" album="" material="bm_tile02_C" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-18 -4 7" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -4 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -17" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -17" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -17" />
                            <Vertex pos="-1.5 -2 17" />
                            <Vertex pos="-1.5 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 -0.124035 0 -1.73649" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-15 -4 23" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -4 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.500002" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 0.500002" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 0 -1 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.727608" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-13 -4 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -4 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.75" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.75" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 128.006 0 0.25 0.1875" texRot="0" texScale="0.25 0.1875" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 0 -1 128.006 0 0.25 0.1875" texRot="0" texScale="0.25 0.1875" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 128.006 0 0.25 0.1875" texRot="0" texScale="0.25 0.1875" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.75" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-7 15 19" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 15 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 1 11" />
                            <Vertex pos="9 1 -11" />
                            <Vertex pos="9 -1 11" />
                            <Vertex pos="9 -1 -11" />
                            <Vertex pos="-9 1 11" />
                            <Vertex pos="-9 1 -11" />
                            <Vertex pos="-9 -1 11" />
                            <Vertex pos="-9 -1 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3968 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3712 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -3712 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 3968 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-15 6 19" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 6 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 11" />
                            <Vertex pos="1 8 -11" />
                            <Vertex pos="1 -8 11" />
                            <Vertex pos="1 -8 -11" />
                            <Vertex pos="-1 8 11" />
                            <Vertex pos="-1 8 -11" />
                            <Vertex pos="-1 -8 11" />
                            <Vertex pos="-1 -8 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-43 -5 8" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 -5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 18" />
                            <Vertex pos="3 3 -18" />
                            <Vertex pos="3 -3 18" />
                            <Vertex pos="3 -3 -18" />
                            <Vertex pos="-3 3 18" />
                            <Vertex pos="-3 3 -18" />
                            <Vertex pos="-0.999996 -2 18" />
                            <Vertex pos="-0.999996 -2 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.928477 -0.371391 0 -1.67126" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.242536 -0.970142 -0 -2.18282" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-45 1 9" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 1 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 19" />
                            <Vertex pos="1 3 -19" />
                            <Vertex pos="1.5 -3 17" />
                            <Vertex pos="1.5 -3 -19" />
                            <Vertex pos="-1 3 19" />
                            <Vertex pos="-1 3 -19" />
                            <Vertex pos="-1 -3 17" />
                            <Vertex pos="-1 -3 -19" />
                        </Vertices>
                        <Face id="0" plane="0.996546 0.0830455 0 -1.24568" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.316228 0.948683 -17.0763" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-43 1 10" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 1 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 18" />
                            <Vertex pos="1 3 -20" />
                            <Vertex pos="1.5 -3 20" />
                            <Vertex pos="1.5 -3 -20" />
                            <Vertex pos="-1 3 18" />
                            <Vertex pos="-1 3 -20" />
                            <Vertex pos="-0.5 -3 20" />
                            <Vertex pos="-0.5 -3 -20" />
                        </Vertices>
                        <Face id="0" plane="0.996546 0.0830455 0 -1.24568" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.996546 -0.0830455 0 -0.747409" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -18.025" album="" material="bm_friction_grass" texgens="1 0 0 -768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-41 1 11" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 1 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 21" />
                            <Vertex pos="1 3 -21" />
                            <Vertex pos="1 -3 19" />
                            <Vertex pos="1 -3 -21" />
                            <Vertex pos="-1 3 21" />
                            <Vertex pos="-1 3 -21" />
                            <Vertex pos="-0.5 -3 19" />
                            <Vertex pos="-0.5 -3 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.996546 -0.0830455 0 -0.747409" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.316228 0.948683 -18.9737" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-43 7 11" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 7 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 21" />
                            <Vertex pos="3 3 -21" />
                            <Vertex pos="3 -3 21" />
                            <Vertex pos="3 -3 -21" />
                            <Vertex pos="-3 1 21" />
                            <Vertex pos="-3 1 -21" />
                            <Vertex pos="-3 -3 21" />
                            <Vertex pos="-3 -3 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.316228 0.948683 0 -1.89737" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-43 11 11" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 11 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 21" />
                            <Vertex pos="3 3 -21" />
                            <Vertex pos="3 -0.999999 21" />
                            <Vertex pos="3 -0.999999 -21" />
                            <Vertex pos="-1 2 21" />
                            <Vertex pos="-1 2 -21" />
                            <Vertex pos="-3 -3 21" />
                            <Vertex pos="-3 -3 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.928477 0.371391 0 -1.67126" album="" material="bm_grid_blank4" texgens="0 -1 0 307.201 0 0 -1 -2176 0 0.208333 0.25" texRot="0" texScale="0.208333 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 -2.18282" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.316228 -0.948683 0 -1.89737" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-28 2 17" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 2 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 27" />
                            <Vertex pos="12 4 -27" />
                            <Vertex pos="12 -4 27" />
                            <Vertex pos="12 -4 -27" />
                            <Vertex pos="-12 4 27" />
                            <Vertex pos="-12 4 -27" />
                            <Vertex pos="-12 -4 27" />
                            <Vertex pos="-12 -4 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-39 12 31.5" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 12 0 0 1 31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-37 12 31.625" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 12 0 0 1 31.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.624998" />
                            <Vertex pos="1 2 -0.374998" />
                            <Vertex pos="1 -2 0.624998" />
                            <Vertex pos="1 -2 -0.374998" />
                            <Vertex pos="-1 2 0.375" />
                            <Vertex pos="-1 2 -0.624998" />
                            <Vertex pos="-1 -2 0.375" />
                            <Vertex pos="-1 -2 -0.624998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1872 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1872 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.125 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -1872 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124034 0 0.992278 -0.496138" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.496137" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-35 12 32" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 12 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.75" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.75" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485071" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-33 12 32.625" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 12 0 0 1 32.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.875" />
                            <Vertex pos="1 2 -0.125" />
                            <Vertex pos="1 -2 0.875" />
                            <Vertex pos="1 -2 -0.125" />
                            <Vertex pos="-1 2 0.125" />
                            <Vertex pos="-1 2 -0.875" />
                            <Vertex pos="-1 -2 0.125" />
                            <Vertex pos="-1 -2 -0.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2000 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2000 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2000 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.468165" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.468165" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-31 12 33.5" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 12 0 0 1 33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 0" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 0" />
                            <Vertex pos="-1 2 3.8147e-006" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 3.8147e-006" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.5 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447212 0 0.894428 -0.447216" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-29 12 34.5" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 12 0 0 1 34.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 0" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 0" />
                            <Vertex pos="-1 2 3.8147e-006" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 3.8147e-006" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2400 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2400 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.5 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2400 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447212 0 0.894428 -0.447216" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-27 12 35.375" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 12 0 0 1 35.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.875004" />
                            <Vertex pos="1 2 -0.125004" />
                            <Vertex pos="1 -2 0.875004" />
                            <Vertex pos="1 -2 -0.125004" />
                            <Vertex pos="-1 2 0.125004" />
                            <Vertex pos="-1 2 -0.875004" />
                            <Vertex pos="-1 -2 0.125004" />
                            <Vertex pos="-1 -2 -0.875004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.375 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.468168" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.468168" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-25 12 36" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 12 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.750004" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.750004" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.250004" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.250004" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2592 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2592 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.25 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2592 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485075" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-23 12 36.375" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 12 0 0 1 36.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.625" />
                            <Vertex pos="1 2 -0.375" />
                            <Vertex pos="1 -2 0.625" />
                            <Vertex pos="1 -2 -0.375" />
                            <Vertex pos="-1 2 0.375" />
                            <Vertex pos="-1 2 -0.625" />
                            <Vertex pos="-1 -2 0.375" />
                            <Vertex pos="-1 -2 -0.625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -2640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -2640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0.125 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -2640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -0.496139" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.496139" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-21 12 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 12 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -1536 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 1792 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2176 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile02_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-18 12 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 12 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 23.5" />
                            <Vertex pos="2 2 -23.5" />
                            <Vertex pos="2 -2 23.5" />
                            <Vertex pos="2 -2 -23.5" />
                            <Vertex pos="-2 2 23.5" />
                            <Vertex pos="-2 2 -23.5" />
                            <Vertex pos="-2 -2 23.5" />
                            <Vertex pos="-2 -2 -23.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -2496 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -2496 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -2496 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -2496 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23.5" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="0 -13 23.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -13 0 0 1 23.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 4.5" />
                            <Vertex pos="6 1 -3.5" />
                            <Vertex pos="6 -1 4.5" />
                            <Vertex pos="6 -1 -4.5" />
                            <Vertex pos="-6 1 4.5" />
                            <Vertex pos="-6 1 -3.5" />
                            <Vertex pos="-6 -1 4.5" />
                            <Vertex pos="-6 -1 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -3.57771" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="0 -11 24" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 4" />
                            <Vertex pos="6 1 -4" />
                            <Vertex pos="6 -1 4" />
                            <Vertex pos="6 -1 -4" />
                            <Vertex pos="-6 1 4" />
                            <Vertex pos="-6 1 -4" />
                            <Vertex pos="-6 -1 4" />
                            <Vertex pos="-6 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="5 -13 36" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -13 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 8" />
                            <Vertex pos="1 3 -8" />
                            <Vertex pos="1 -3 8" />
                            <Vertex pos="1 -3 -8" />
                            <Vertex pos="-1 3 8" />
                            <Vertex pos="-1 3 -8" />
                            <Vertex pos="-1 -3 8" />
                            <Vertex pos="-1 -3 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-5 -13 36" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -13 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 8" />
                            <Vertex pos="1 3 -8" />
                            <Vertex pos="1 -3 8" />
                            <Vertex pos="1 -3 -8" />
                            <Vertex pos="-1 3 8" />
                            <Vertex pos="-1 3 -8" />
                            <Vertex pos="-1 -3 8" />
                            <Vertex pos="-1 -3 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-15 -11 19" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -11 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 11" />
                            <Vertex pos="1 5 -11" />
                            <Vertex pos="1 -5 11" />
                            <Vertex pos="1 -5 -11" />
                            <Vertex pos="-1 5 11" />
                            <Vertex pos="-1 5 -11" />
                            <Vertex pos="-1 -5 11" />
                            <Vertex pos="-1 -5 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-15 -4 15" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -4 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7" />
                            <Vertex pos="1 2 -7" />
                            <Vertex pos="1 -2 7" />
                            <Vertex pos="1 -2 -7" />
                            <Vertex pos="-1 2 7" />
                            <Vertex pos="-1 2 -7" />
                            <Vertex pos="-1 -2 7" />
                            <Vertex pos="-1 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="4 16 6.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 16 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 1.5 16.75" />
                            <Vertex pos="2.5 1.5 -16.75" />
                            <Vertex pos="2 0 16.75" />
                            <Vertex pos="2 0 -16.75" />
                            <Vertex pos="-2 2 16.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-2 0 16.75" />
                            <Vertex pos="-2 0 -16.75" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0.316228 0 -1.89737" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.110432 0.993884 -0 -1.7669" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="8 15 11" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 15 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 19" />
                            <Vertex pos="2 1 -19" />
                            <Vertex pos="2 -1 19" />
                            <Vertex pos="2 -1 -19" />
                            <Vertex pos="-2 1 19" />
                            <Vertex pos="-2 1 -19" />
                            <Vertex pos="-2 -1 19" />
                            <Vertex pos="-2 -1 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4096 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3840 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_grid_blank4" texgens="1 0 0 -3840 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 4096 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="12 15 22" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 15 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 8" />
                            <Vertex pos="2 1 -8" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -8" />
                            <Vertex pos="-2 1 8" />
                            <Vertex pos="-2 1 -8" />
                            <Vertex pos="-2 -1 8" />
                            <Vertex pos="-2 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4096 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -3840 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -3840 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 4096 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="8 -30 29" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -30 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 14 39" />
                            <Vertex pos="4 14 -39" />
                            <Vertex pos="4 -14 39" />
                            <Vertex pos="4 -14 -39" />
                            <Vertex pos="-4 14 39" />
                            <Vertex pos="-4 14 -39" />
                            <Vertex pos="-4 -14 39" />
                            <Vertex pos="-4 -14 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -3584 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 3840 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-8 -40 29" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -40 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 39" />
                            <Vertex pos="4 12 -39" />
                            <Vertex pos="4 -12 39" />
                            <Vertex pos="4 -12 -39" />
                            <Vertex pos="-4 12 39" />
                            <Vertex pos="-4 12 -39" />
                            <Vertex pos="-4 -12 39" />
                            <Vertex pos="-4 -12 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -4864 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 5120 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="0 -32 9" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -32 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 16 19" />
                            <Vertex pos="4 16 -19" />
                            <Vertex pos="4 -16 19" />
                            <Vertex pos="4 -16 -19" />
                            <Vertex pos="-4 16 19" />
                            <Vertex pos="-4 16 -19" />
                            <Vertex pos="-4 -16 19" />
                            <Vertex pos="-4 -16 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -3840 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 4096 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-15 -3 37" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -3 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 13 7" />
                            <Vertex pos="1 13 -7" />
                            <Vertex pos="1 -13 7" />
                            <Vertex pos="1 -13 -7" />
                            <Vertex pos="-1 13 7" />
                            <Vertex pos="-1 13 -7" />
                            <Vertex pos="-1 -13 7" />
                            <Vertex pos="-1 -13 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 2432 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-15 12 34" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 12 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 3" />
                            <Vertex pos="1 2 -4" />
                            <Vertex pos="1 -2 4" />
                            <Vertex pos="1 -2 -4" />
                            <Vertex pos="-1 2 3" />
                            <Vertex pos="-1 2 -4" />
                            <Vertex pos="-1 -2 4" />
                            <Vertex pos="-1 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -3.3955" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-12 12 23" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 12 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15" />
                            <Vertex pos="2 2 13" />
                            <Vertex pos="1.5 -2 15" />
                            <Vertex pos="1.5 -2 13" />
                            <Vertex pos="-2 2 15" />
                            <Vertex pos="-2 2 13" />
                            <Vertex pos="-2 -2 15" />
                            <Vertex pos="-2 -2 13" />
                        </Vertices>
                        <Face id="0" plane="0.992278 -0.124035 0 -1.73649" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 13" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="10 -15 36" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -15 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 8" />
                            <Vertex pos="4 1 -8" />
                            <Vertex pos="4 -1 8" />
                            <Vertex pos="4 -1 -8" />
                            <Vertex pos="-4 1 8" />
                            <Vertex pos="-4 1 -8" />
                            <Vertex pos="-4 -1 8" />
                            <Vertex pos="-4 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-10 -15 36" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -15 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 8" />
                            <Vertex pos="4 1 -8" />
                            <Vertex pos="4 -1 8" />
                            <Vertex pos="4 -1 -8" />
                            <Vertex pos="-4 1 8" />
                            <Vertex pos="-4 1 -8" />
                            <Vertex pos="-4 -1 8" />
                            <Vertex pos="-4 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-3 -13 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -13 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1" />
                            <Vertex pos="1 3 -1" />
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="-1 3 1" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-9 12 23.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 12 0 0 1 23.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 15.5" />
                            <Vertex pos="1 2 12.5" />
                            <Vertex pos="0.5 -2 15.5" />
                            <Vertex pos="0.5 -2 12.5" />
                            <Vertex pos="-1 2 14.5" />
                            <Vertex pos="-1 2 12.5" />
                            <Vertex pos="-1.5 -2 14.5" />
                            <Vertex pos="-1.5 -2 12.5" />
                        </Vertices>
                        <Face id="0" plane="0.992278 -0.124035 0 -0.744208" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 0.124035 0 -1.24035" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.446516 0.0558146 0.893033 -13.5071" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-3 13 16" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 13 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999999 23" />
                            <Vertex pos="1 0.999999 -24" />
                            <Vertex pos="1.5 -0.999999 24" />
                            <Vertex pos="1.5 -0.999999 -24" />
                            <Vertex pos="-1 0.999999 23" />
                            <Vertex pos="-1 0.999999 -24" />
                            <Vertex pos="-1 -0.999999 24" />
                            <Vertex pos="-1 -0.999999 -24" />
                        </Vertices>
                        <Face id="0" plane="0.970142 0.242536 0 -1.21268" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999999" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999999" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -21.019" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-6 12 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 12 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -7.5" />
                            <Vertex pos="2 2 -23.5" />
                            <Vertex pos="2 -2 -7.5" />
                            <Vertex pos="2 -2 -23.5" />
                            <Vertex pos="-4 2 -7.5" />
                            <Vertex pos="-4 2 -23.5" />
                            <Vertex pos="-4 -2 -7.5" />
                            <Vertex pos="-4 -2 -23.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 7.5" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-2 11 16" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 11 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 24" />
                            <Vertex pos="0.5 1 -24" />
                            <Vertex pos="2 -1 24" />
                            <Vertex pos="2 -1 -24" />
                            <Vertex pos="-2 1 24" />
                            <Vertex pos="-2 1 -24" />
                            <Vertex pos="-2 -1 24" />
                            <Vertex pos="-2 -1 -24" />
                        </Vertices>
                        <Face id="0" plane="0.8 0.6 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-2 8 16" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 8 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 24" />
                            <Vertex pos="2 2 -24" />
                            <Vertex pos="2 -2 24" />
                            <Vertex pos="2 -2 -24" />
                            <Vertex pos="-2 2 24" />
                            <Vertex pos="-2 2 -24" />
                            <Vertex pos="-2 -2 24" />
                            <Vertex pos="-2 -2 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-3 -25 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -25 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 3" />
                            <Vertex pos="5 1 -1" />
                            <Vertex pos="5 -3 3" />
                            <Vertex pos="5 -3 -1" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="0 -41 38.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -41 0 0 1 38.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 -0.249996" />
                            <Vertex pos="2 3 -2.25" />
                            <Vertex pos="2 0 1.25" />
                            <Vertex pos="2 0 -0.749996" />
                            <Vertex pos="-2 3 -0.249996" />
                            <Vertex pos="-2 3 -2.25" />
                            <Vertex pos="0 0 1.25" />
                            <Vertex pos="0 0 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.83205 -0.5547 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2816 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -2560 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447213 0.894428 -1.11803" album="" material="bm_tile10_A" texgens="1 0 0 -1536 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="1.78595e-006 -0.447215 -0.894427 -0.67082" album="" material="bm_grid_blank4" texgens="-1 0 0 2816 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="3 -48 41" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -48 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 1" />
                            <Vertex pos="1 0 -5" />
                            <Vertex pos="1 -4 1" />
                            <Vertex pos="1 -4 -5" />
                            <Vertex pos="-7 0 1" />
                            <Vertex pos="-7 0 -5" />
                            <Vertex pos="-7 -4 1" />
                            <Vertex pos="-7 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="10 -49 14" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -49 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 22" />
                            <Vertex pos="2 1 -24" />
                            <Vertex pos="2 -1 22" />
                            <Vertex pos="2 -1 -24" />
                            <Vertex pos="-6 0.999996 24" />
                            <Vertex pos="-6 1 -24" />
                            <Vertex pos="-6 -0.500004 24" />
                            <Vertex pos="-6 -0.500004 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.0623778 -0.998053 -0 -0.873297" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -21.8282" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="15 -46.75 12" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -46.75 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 2.25 22" />
                            <Vertex pos="1.5 2.25 -22" />
                            <Vertex pos="3 -5.25 22" />
                            <Vertex pos="3 -5.25 -22" />
                            <Vertex pos="-3 3.25 22" />
                            <Vertex pos="-3 3.25 -22" />
                            <Vertex pos="-3 -5.25 22" />
                            <Vertex pos="-3 -5.25 -22" />
                        </Vertices>
                        <Face id="0" plane="0.980581 0.196116 0 -1.91213" album="" material="bm_grid_blank4" texgens="0 1 0 -1632 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1888 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.21693 0.976187 -0 -2.52182" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.25" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -22" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="15 -54 12.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -54 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 21.75" />
                            <Vertex pos="3 2 -22.25" />
                            <Vertex pos="3 -2 22.75" />
                            <Vertex pos="3 -2 -22.25" />
                            <Vertex pos="-3 2 21.75" />
                            <Vertex pos="-3 2 -22.25" />
                            <Vertex pos="-1 -2 22.75" />
                            <Vertex pos="-1 -2 -22.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 2784 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -1.78885" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 2784 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 2784 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 2784 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -21.5857" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="16 -77 12" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -77 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 2.5 22" />
                            <Vertex pos="2.5 2.5 -22" />
                            <Vertex pos="4 -3 22" />
                            <Vertex pos="4 -3 -22" />
                            <Vertex pos="-2 3 22" />
                            <Vertex pos="-2 3 -22" />
                            <Vertex pos="-4 -2 22" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="0.964764 0.263117 0 -3.0697" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.928477 0.371391 0 -2.97113" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.110432 0.993884 -0 -2.76079" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.124035 -0.992278 -0 -2.48069" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -22" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="16 -81 12" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -81 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.00001 1 22" />
                            <Vertex pos="4.00001 1 -22" />
                            <Vertex pos="2.00001 -1 22" />
                            <Vertex pos="2.00001 -1 -22" />
                            <Vertex pos="-4 2 22" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-2.00001 -1 22" />
                            <Vertex pos="-2.00001 -1 -22" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12133" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.832052 -0.554698 0 -2.21881" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.124035 0.992278 -0 -1.48842" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -22" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="16 -84 25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -84 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 8.99998" />
                            <Vertex pos="2 2 -8.99998" />
                            <Vertex pos="2 -2 8.99998" />
                            <Vertex pos="2 -2 3.00001" />
                            <Vertex pos="-2 2 8.99998" />
                            <Vertex pos="-2 2 -8.99998" />
                            <Vertex pos="-2 -2 8.99998" />
                            <Vertex pos="-2 -2 3.00001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8.99998" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.948683 -0.316228 -0.948679" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.0833333" texRot="0" texScale="0.25 0.0833333" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="16 -87 31.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -87 0 0 1 31.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 2.74999" />
                            <Vertex pos="2 0.999992 -3.24999" />
                            <Vertex pos="2 -1 3.24999" />
                            <Vertex pos="2 -1 1.25001" />
                            <Vertex pos="-2 1 2.74999" />
                            <Vertex pos="-2 0.999992 -3.24999" />
                            <Vertex pos="-2 -1 3.24999" />
                            <Vertex pos="-2 -1 1.25001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -11136 0 0 -1 -4000 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 11136 0 0 -1 -4000 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -1.33117e-006 -0.999996" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -2.91042" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.913812 -0.406137 -0.406137" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.125" texRot="0" texScale="0.25 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="16 -89 34" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -89 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -1.5" />
                            <Vertex pos="2 -1 1.5" />
                            <Vertex pos="2 -1 0.499996" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -1.5" />
                            <Vertex pos="-2 -1 1.5" />
                            <Vertex pos="-2 -1 0.499996" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -11392 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 11392 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.894427" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707106 -0.707107 -0.353555" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="16 -91 35.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -91 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -0.250004" />
                            <Vertex pos="2 1 -1.25" />
                            <Vertex pos="2 -1 1.24999" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="-2 1 -0.250004" />
                            <Vertex pos="-2 1 -1.25" />
                            <Vertex pos="-2 -1 1.24999" />
                            <Vertex pos="-2 -1 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -11648 0 0 -1 -4576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 11648 0 0 -1 -4576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.599998 0.800001 -0.399995" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.4" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="16 -93 37.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -93 0 0 1 37.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.00001 -0.500008" />
                            <Vertex pos="2 1.00001 -1.5" />
                            <Vertex pos="2 -1 1.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="-2 1.00001 -0.500008" />
                            <Vertex pos="-2 1.00001 -1.5" />
                            <Vertex pos="-2 -1 1.5" />
                            <Vertex pos="-2 -1 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -11904 0 0 -1 -4800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 11904 0 0 -1 -4800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.00001" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707106 0.707107 -0.353554" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707105 -0.707108 -0.353551" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="16 -95 39.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -95 0 0 1 39.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.999992 -0.250004" />
                            <Vertex pos="2 0.999992 -1.25" />
                            <Vertex pos="2 -1 1.25" />
                            <Vertex pos="2 -1 0.249996" />
                            <Vertex pos="-2 0.999992 -0.250004" />
                            <Vertex pos="-2 0.999992 -1.25" />
                            <Vertex pos="-2 -1 1.25" />
                            <Vertex pos="-2 -1 0.249996" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -12160 0 0 -1 -5024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 12160 0 0 -1 -5024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999992" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2592 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2592 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.600003 0.799998 -0.399995" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.600001 -0.8 -0.400004" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="16 -97 40.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -97 0 0 1 40.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 3.8147e-006" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 3.8147e-006" />
                            <Vertex pos="-2 1 3.8147e-006" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 3.8147e-006" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -12416 0 0 -1 -5184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 12416 0 0 -1 -5184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447212 0.894428 -0.447216" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447215 -0.894427 -0.447212" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="16 -99 41.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -99 0 0 1 41.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.250004" />
                            <Vertex pos="2 1 -0.749996" />
                            <Vertex pos="2 -1 0.75" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.250004" />
                            <Vertex pos="-2 1 -0.749996" />
                            <Vertex pos="-2 -1 0.75" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -12672 0 0 -1 -5280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 12672 0 0 -1 -5280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2848 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2848 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242534 0.970143 -0.485073" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242534 -0.970143 -0.48507" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="16 -101 41.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -101 0 0 1 41.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -0.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 -12928 0 0 -1 -5312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 12928 0 0 -1 -5312 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 0 -1 -2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 -2048 0 0 -1 -2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 2304 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="13 -105 16" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -105 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.99999 26" />
                            <Vertex pos="1 2.99999 -26" />
                            <Vertex pos="1 -3 26" />
                            <Vertex pos="1 -3 -26" />
                            <Vertex pos="-1 1.49999 26" />
                            <Vertex pos="-1 1.49999 -26" />
                            <Vertex pos="-1 -3 26" />
                            <Vertex pos="-1 -3 -26" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.6 0.8 0 -1.79999" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="11 -107 16.5" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -107 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 25.5" />
                            <Vertex pos="1 1 -26.5" />
                            <Vertex pos="1 -0.999992 25.5" />
                            <Vertex pos="1 -1 -26.5" />
                            <Vertex pos="-1 1 26.5" />
                            <Vertex pos="-1 1 -26.5" />
                            <Vertex pos="-1 -0.999992 26.5" />
                            <Vertex pos="-1 -1 -26.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="7.53493e-008 -1 1.50699e-007 -0.999996" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -23.2551" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="12 -110 17" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -110 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.99999 27" />
                            <Vertex pos="2 1.99999 -27" />
                            <Vertex pos="1.5 -0.999992 27" />
                            <Vertex pos="1.5 -0.999992 -27" />
                            <Vertex pos="-2 1.99999 27" />
                            <Vertex pos="-2 1.99999 -27" />
                            <Vertex pos="-2 -1.99999 27" />
                            <Vertex pos="-2 -1.99999 -27" />
                        </Vertices>
                        <Face id="0" plane="0.986394 -0.1644 0 -1.64399" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.274721 -0.961524 0 -1.3736" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="9 -109 17" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -109 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.00001 26" />
                            <Vertex pos="1 1 -27" />
                            <Vertex pos="1 -1 27" />
                            <Vertex pos="1 -1 -27" />
                            <Vertex pos="-1 1.00001 26" />
                            <Vertex pos="-1 1 -27" />
                            <Vertex pos="-1 -1 27" />
                            <Vertex pos="-1 -1 -27" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -1.88935e-007 -1.00001" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447212 0.894428 -23.7023" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="9 -107 16.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -107 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 26.5" />
                            <Vertex pos="1 1 -26.5" />
                            <Vertex pos="1 -1 26.5" />
                            <Vertex pos="1 -1 -26.5" />
                            <Vertex pos="-1 1 26.5" />
                            <Vertex pos="-1 1 -26.5" />
                            <Vertex pos="-1 -1 26.5" />
                            <Vertex pos="-1 -1 -26.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26.5" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="10 -105 16.5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -105 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 26.5" />
                            <Vertex pos="2 1 -26.5" />
                            <Vertex pos="2 -1 26.5" />
                            <Vertex pos="2 -1 -26.5" />
                            <Vertex pos="-1.5 1 26.5" />
                            <Vertex pos="-1.5 1 -26.5" />
                            <Vertex pos="-2 -1 26.5" />
                            <Vertex pos="-2 -1 -26.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -1.69775" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26.5" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="8 -112 17" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -112 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 27" />
                            <Vertex pos="2 2 -27" />
                            <Vertex pos="2 -2 27" />
                            <Vertex pos="2 -2 -27" />
                            <Vertex pos="-2 2 27" />
                            <Vertex pos="-2 2 -27" />
                            <Vertex pos="-2 -2 27" />
                            <Vertex pos="-2 -2 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="1" type="999" pos="4 -112 36" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -112 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -4" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile01_C" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-8 -96 22" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -96 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 32" />
                            <Vertex pos="2 2 -32" />
                            <Vertex pos="2 -2 31" />
                            <Vertex pos="2 -2 -32" />
                            <Vertex pos="-2 2 32" />
                            <Vertex pos="-2 2 -32" />
                            <Vertex pos="-2 -2 31" />
                            <Vertex pos="-2 -2 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -30.5595" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-7 -92 22" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -92 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1.5 32" />
                            <Vertex pos="3 1.5 -32" />
                            <Vertex pos="1 -2 32" />
                            <Vertex pos="1 -2 -32" />
                            <Vertex pos="-3 2 32" />
                            <Vertex pos="-3 2 -32" />
                            <Vertex pos="-3 -2 32" />
                            <Vertex pos="-3 -2 -32" />
                        </Vertices>
                        <Face id="0" plane="0.868243 -0.496139 0 -1.86052" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0830455 0.996546 -0 -1.74396" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -32" album="" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-7 -89 22.5" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -89 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 31.5" />
                            <Vertex pos="3 1 -32.5" />
                            <Vertex pos="3 -1.5 31.5" />
                            <Vertex pos="3 -1.5 -32.5" />
                            <Vertex pos="-3 1 32.5" />
                            <Vertex pos="-3 1 -32.5" />
                            <Vertex pos="-3 -1 32.5" />
                            <Vertex pos="-3 -1 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.0830455 -0.996546 -0 -1.24568" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -31.5646" album="" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-7 -87 23" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -87 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 33" />
                            <Vertex pos="3 1 -33" />
                            <Vertex pos="3 -1 33" />
                            <Vertex pos="3 -1 -33" />
                            <Vertex pos="-3 1 32" />
                            <Vertex pos="-3 1 -33" />
                            <Vertex pos="-3 -1 32" />
                            <Vertex pos="-3 -1 -33" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.164399 0 0.986394 -32.0578" album="" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-6 -84 23" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -84 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 33" />
                            <Vertex pos="2 2 -33" />
                            <Vertex pos="2 -2 33" />
                            <Vertex pos="2 -2 -33" />
                            <Vertex pos="-2 2 33" />
                            <Vertex pos="-2 2 -33" />
                            <Vertex pos="-2 -2 33" />
                            <Vertex pos="-2 -2 -33" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -33" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-2 -49 55" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -49 0 0 1 55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 1" />
                            <Vertex pos="2 3 -1" />
                            <Vertex pos="2 -3 1" />
                            <Vertex pos="2 -3 -1" />
                            <Vertex pos="-2 3 1" />
                            <Vertex pos="-2 3 -3" />
                            <Vertex pos="-2 -3 1" />
                            <Vertex pos="-2 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -1.78885" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="5" type="999" pos="-2 -42 55" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -42 0 0 1 55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 -1" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 1" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile04_C" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="9" type="999" pos="2 -36 55" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -36 0 0 1 55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 -1" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 1" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile04_C" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="0 -31 55.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -31 0 0 1 55.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.5" />
                            <Vertex pos="4 1 -1.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 -1 -1.5" />
                            <Vertex pos="-4 1 1.5" />
                            <Vertex pos="-4 1 -1.5" />
                            <Vertex pos="-4 -0.5 1.5" />
                            <Vertex pos="-4 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.0623783 -0.998053 -0 -0.748539" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -0.992278" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="0 -29 56" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -29 0 0 1 56 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 1 1" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -1 1" />
                            <Vertex pos="-4 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -1.48842" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="13" type="999" pos="2 -25 57" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -25 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 -1" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile04_C" texgens="1 0 0 -1024 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="17" type="999" pos="-3 -21 57" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -21 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile04_C" texgens="1 0 0 -1280 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="0 -17 57" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -17 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 1" />
                            <Vertex pos="4 1 -1" />
                            <Vertex pos="4 -1 1" />
                            <Vertex pos="4 -1 -1" />
                            <Vertex pos="-4 1 1" />
                            <Vertex pos="-4 1 -1" />
                            <Vertex pos="-4 -1 1" />
                            <Vertex pos="-4 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="0 -14 57" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -14 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 2 -1" />
                            <Vertex pos="-6 -2 1" />
                            <Vertex pos="-6 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="0 -14 65" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -14 0 0 1 65 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 2 -1" />
                            <Vertex pos="-6 -2 1" />
                            <Vertex pos="-6 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="0 -32 66" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -32 0 0 1 66 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 16 2" />
                            <Vertex pos="4 16 -2" />
                            <Vertex pos="4 -16 2" />
                            <Vertex pos="4 -16 -2" />
                            <Vertex pos="-4 16 2" />
                            <Vertex pos="-4 16 -2" />
                            <Vertex pos="-4 -16 2" />
                            <Vertex pos="-4 -16 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -3840 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 4096 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="0 -18 70" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -18 0 0 1 70 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 2" />
                            <Vertex pos="4 2 -2" />
                            <Vertex pos="4 0 2" />
                            <Vertex pos="4 0 -2" />
                            <Vertex pos="-4 2 2" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 -2 2" />
                            <Vertex pos="-4 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -0.970143" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="0 -21 70" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -21 0 0 1 70 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 1" />
                            <Vertex pos="4 3 -2" />
                            <Vertex pos="4 -3 1" />
                            <Vertex pos="4 -3 -2" />
                            <Vertex pos="-4 1 2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -3 2" />
                            <Vertex pos="-4 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 -1.94029" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -1.48842" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="8 -20 71" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -20 0 0 1 71 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 3" />
                            <Vertex pos="4 4 -3" />
                            <Vertex pos="4 -4 3" />
                            <Vertex pos="4 -4 -3" />
                            <Vertex pos="-4 4 3" />
                            <Vertex pos="-4 4 -3" />
                            <Vertex pos="-4 -4 3" />
                            <Vertex pos="-4 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-8 -20 73" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -20 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 5" />
                            <Vertex pos="4 4 -5" />
                            <Vertex pos="4 -4 5" />
                            <Vertex pos="4 -4 -5" />
                            <Vertex pos="-4 4 5" />
                            <Vertex pos="-4 4 -5" />
                            <Vertex pos="-4 -4 5" />
                            <Vertex pos="-4 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-7 -28 73" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -28 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 5" />
                            <Vertex pos="5 4 -5" />
                            <Vertex pos="5 -4 5" />
                            <Vertex pos="5 -4 -5" />
                            <Vertex pos="-5 4 5" />
                            <Vertex pos="-5 4 -5" />
                            <Vertex pos="-5 -4 5" />
                            <Vertex pos="-5 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="8 -25 71" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -25 0 0 1 71 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 1.00001" />
                            <Vertex pos="4 1 -3.00002" />
                            <Vertex pos="4 -0.999998 1.00001" />
                            <Vertex pos="4 -0.999998 -3.00002" />
                            <Vertex pos="-4 1 3.00001" />
                            <Vertex pos="-4 1 -3.00002" />
                            <Vertex pos="-4 1.90735e-006 3.00001" />
                            <Vertex pos="-4 1.90735e-006 -3.00002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.124035 -0.992278 -0 -0.496137" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -1.94029" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.00002" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="8 -26.5 70" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -26.5 0 0 1 70 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 2" />
                            <Vertex pos="4 0.5 -2" />
                            <Vertex pos="4 -1.5 2" />
                            <Vertex pos="4 -1.5 -2" />
                            <Vertex pos="-4 1.5 1" />
                            <Vertex pos="-4 1.5 -2" />
                            <Vertex pos="-4 -1.5 1" />
                            <Vertex pos="-4 -1.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1088 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1344 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.124035 0.992278 -0 -0.992278" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -1.48842" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="2 -26 69.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -26 0 0 1 69.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.5" />
                            <Vertex pos="2 2 -1.5" />
                            <Vertex pos="2 -2 1.5" />
                            <Vertex pos="2 -2 -1.5" />
                            <Vertex pos="-2 2 1.5" />
                            <Vertex pos="-2 2 -1.5" />
                            <Vertex pos="-2 0 1.5" />
                            <Vertex pos="-2 0 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -0.894427" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="6 -32 73" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -32 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 5" />
                            <Vertex pos="6 4 -5" />
                            <Vertex pos="6 -4 5" />
                            <Vertex pos="6 -4 -5" />
                            <Vertex pos="-6 4 5" />
                            <Vertex pos="-6 4 -5" />
                            <Vertex pos="-6 -4 5" />
                            <Vertex pos="-6 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="13 -26 32" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -26 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 42" />
                            <Vertex pos="1 2 -42" />
                            <Vertex pos="1 -2 41.5" />
                            <Vertex pos="1 -2 -42" />
                            <Vertex pos="-1 2 42" />
                            <Vertex pos="-1 2 -42" />
                            <Vertex pos="-1 -2 41.5" />
                            <Vertex pos="-1 -2 -42" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -41.4276" album="" material="bm_friction_bounce_high" texgens="1 0 0 -1280 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -42" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="13 -20 32" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -20 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 4 42" />
                            <Vertex pos="-1 4 -42" />
                            <Vertex pos="0.999999 -4 42" />
                            <Vertex pos="0.999999 -4 -42" />
                            <Vertex pos="-1 -4 42" />
                            <Vertex pos="-1 -4 -42" />
                        </Vertices>
                        <Face id="0" plane="0.970143 0.242536 0 4.76837e-007" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 2 3" />
                        </Face>
                        <Face id="3" plane="0 0 1 -42" album="" material="bm_tile09_A" texgens="1 0 0 -1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -42" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 1" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="13.5 -41 35" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 -41 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 43" />
                            <Vertex pos="1 3 -45" />
                            <Vertex pos="0.5 -3 45" />
                            <Vertex pos="0.5 -3 -45" />
                            <Vertex pos="-0.5 3 43" />
                            <Vertex pos="-0.5 3 -45" />
                            <Vertex pos="-0.5 -3 45" />
                            <Vertex pos="-0.5 -3 -45" />
                        </Vertices>
                        <Face id="0" plane="0.996546 -0.0830455 0 -0.747409" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2624 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2368 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -41.7421" album="" material="bm_tile09_A" texgens="1 0 0 -1152 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -45" album="" material="bm_grid_blank4" texgens="-1 0 0 2624 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="12.5 -41 35.5" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -41 0 0 1 35.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 45.5" />
                            <Vertex pos="0.5 3 -45.5" />
                            <Vertex pos="0.5 -3 44.5" />
                            <Vertex pos="0.5 -3 -45.5" />
                            <Vertex pos="-0.5 3 45.5" />
                            <Vertex pos="-0.5 3 -45.5" />
                            <Vertex pos="-0.5 -3 44.5" />
                            <Vertex pos="-0.5 -3 -45.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2752 0 0 -1 4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2496 0 0 -1 4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.164399 0.986394 -44.3877" album="" material="bm_tile09_A" texgens="1 0 0 -1408 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -45.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2752 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="11 -40 75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -40 0 0 1 75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 6" />
                            <Vertex pos="1 2 -7" />
                            <Vertex pos="1 -2 6" />
                            <Vertex pos="1 -2 -7" />
                            <Vertex pos="-1 2 7" />
                            <Vertex pos="-1 2 -7" />
                            <Vertex pos="-1 -2 7" />
                            <Vertex pos="-1 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -5.81378" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="9 -40 75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -40 0 0 1 75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7" />
                            <Vertex pos="1 2 -7" />
                            <Vertex pos="1 -2 7" />
                            <Vertex pos="1 -2 -7" />
                            <Vertex pos="-1 2 7" />
                            <Vertex pos="-1 2 -7" />
                            <Vertex pos="-1 -2 7" />
                            <Vertex pos="-1 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-11 -40 76" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -40 0 0 1 76 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 8" />
                            <Vertex pos="1 2 -8" />
                            <Vertex pos="1 -2 8" />
                            <Vertex pos="1 -2 -8" />
                            <Vertex pos="-1 2 8" />
                            <Vertex pos="-1 2 -8" />
                            <Vertex pos="-1 -2 8" />
                            <Vertex pos="-1 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="0 -37 78" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -37 0 0 1 78 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 10" />
                            <Vertex pos="12 1 -10" />
                            <Vertex pos="12 -1 10" />
                            <Vertex pos="12 -1 -10" />
                            <Vertex pos="-12 1 10" />
                            <Vertex pos="-12 1 -10" />
                            <Vertex pos="-12 -1 10" />
                            <Vertex pos="-12 -1 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="0 -43 78" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -43 0 0 1 78 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 10" />
                            <Vertex pos="12 1 -10" />
                            <Vertex pos="12 -1 10" />
                            <Vertex pos="12 -1 -10" />
                            <Vertex pos="-12 1 10" />
                            <Vertex pos="-12 1 -10" />
                            <Vertex pos="-12 -1 10" />
                            <Vertex pos="-12 -1 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-1 15 37" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 15 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15 1 7" />
                            <Vertex pos="15 1 -7" />
                            <Vertex pos="15 -1 7" />
                            <Vertex pos="15 -1 -7" />
                            <Vertex pos="-9 1 7" />
                            <Vertex pos="-9 1 -7" />
                            <Vertex pos="-9 -1 7" />
                            <Vertex pos="-9 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -15" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-4.76837e-007 -10 53" rot="1 0 0 0" scale="" transform="1 0 0 -4.76837e-007 0 1 0 -10 0 0 1 53 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -2.00001 3" />
                            <Vertex pos="10 5.99999 -3" />
                            <Vertex pos="6 -5.99999 3" />
                            <Vertex pos="10 -5.99999 -3" />
                            <Vertex pos="-6 -2.00001 3" />
                            <Vertex pos="-10 5.99999 -3" />
                            <Vertex pos="-6 -5.99999 3" />
                            <Vertex pos="-10 -5.99999 -3" />
                        </Vertices>
                        <Face id="0" plane="0.83205 -0 0.5547 -6.6564" album="" material="bm_grid_blank4" texgens="0 1 0 -5120 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.83205 0 0.5547 -6.6564" album="" material="bm_grid_blank4" texgens="0 -1 0 5376 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.6 0.8 -1.19999" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -5.99999" album="" material="bm_grid_blank4" texgens="1 0 0 -2816 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2816 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-8 -20 85" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -20 0 0 1 85 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 7" />
                            <Vertex pos="4 4 -7" />
                            <Vertex pos="4 -4 7" />
                            <Vertex pos="4 -4 -7" />
                            <Vertex pos="-4 4 7" />
                            <Vertex pos="-4 4 -7" />
                            <Vertex pos="-4 -4 7" />
                            <Vertex pos="-4 -4 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -4352 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 4608 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 4608 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -4352 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -4352 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 4608 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-6 -34 73" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -34 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 5" />
                            <Vertex pos="6 2 -5" />
                            <Vertex pos="6 -2 5" />
                            <Vertex pos="6 -2 -5" />
                            <Vertex pos="-6 2 5" />
                            <Vertex pos="-6 2 -5" />
                            <Vertex pos="-6 -2 5" />
                            <Vertex pos="-6 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-6 -30 85" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -30 0 0 1 85 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 7" />
                            <Vertex pos="6 6 -7" />
                            <Vertex pos="6 -6 7" />
                            <Vertex pos="6 -6 -7" />
                            <Vertex pos="-6 6 7" />
                            <Vertex pos="-6 6 -7" />
                            <Vertex pos="-6 -6 7" />
                            <Vertex pos="-6 -6 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -4608 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 4864 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 -1 0 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 -1 0 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="6 -32 85" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -32 0 0 1 85 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 7" />
                            <Vertex pos="6 4 -7" />
                            <Vertex pos="6 -4 7" />
                            <Vertex pos="6 -4 -7" />
                            <Vertex pos="-6 4 7" />
                            <Vertex pos="-6 4 -7" />
                            <Vertex pos="-6 -4 7" />
                            <Vertex pos="-6 -4 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -4352 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 4608 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="0 -40 90" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -40 0 0 1 90 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 2" />
                            <Vertex pos="12 4 -2" />
                            <Vertex pos="12 -4 2" />
                            <Vertex pos="12 -4 -2" />
                            <Vertex pos="-12 4 2" />
                            <Vertex pos="-12 4 -2" />
                            <Vertex pos="-12 -4 2" />
                            <Vertex pos="-12 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -4352 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 4608 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 5120 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -4864 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -4864 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 5120 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-13 -40 76" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -40 0 0 1 76 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 8" />
                            <Vertex pos="1 4 -8" />
                            <Vertex pos="1 -4 8" />
                            <Vertex pos="1 -4 -8" />
                            <Vertex pos="-0.999999 4 8" />
                            <Vertex pos="-0.999999 4 -8" />
                            <Vertex pos="9.53674e-007 -4 8" />
                            <Vertex pos="9.53674e-007 -4 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 -0.124035 0 -0.496138" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-9.53674e-007 -36 103" rot="1 0 0 0" scale="" transform="1 0 0 -9.53674e-007 0 1 0 -36 0 0 1 103 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 7.99999 11" />
                            <Vertex pos="12 7.99999 -11" />
                            <Vertex pos="8 -4 11" />
                            <Vertex pos="12 -8 -11" />
                            <Vertex pos="-6 7.99999 11" />
                            <Vertex pos="-12 7.99999 -11" />
                            <Vertex pos="-6 -4 11" />
                            <Vertex pos="-12 -8 -11" />
                        </Vertices>
                        <Face id="0" plane="0.98387 -0 0.178885 -9.8387" album="" material="bm_grid_blank4" texgens="0 1 0 -4864 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.964764 0 0.263117 -8.68287" album="" material="bm_grid_blank4" texgens="0 -1 0 5120 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -7.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.98387 0.178885 -5.90322" album="" material="bm_grid_blank4" texgens="1 0 0 -3328 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_tile09_A" texgens="1 0 0 -1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 3584 0 -1 0 5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-8 -20 98" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -20 0 0 1 98 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.90735e-006 6" />
                            <Vertex pos="4 4 -6" />
                            <Vertex pos="2 -4 6" />
                            <Vertex pos="4 -4 -6" />
                            <Vertex pos="-2 -1.90735e-006 6" />
                            <Vertex pos="-4 4 -6" />
                            <Vertex pos="-2 -4 6" />
                            <Vertex pos="-4 -4 -6" />
                        </Vertices>
                        <Face id="0" plane="0.986394 -0 0.164399 -2.95918" album="" material="bm_grid_blank4" texgens="0 1 0 -4352 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 0 0.164399 -2.95918" album="" material="bm_grid_blank4" texgens="0 -1 0 4608 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 0.316228 -1.89737" album="" material="bm_grid_blank4" texgens="-1 0 0 4608 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -4352 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 4608 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-6 -26 98" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -26 0 0 1 98 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 6" />
                            <Vertex pos="6 2 -6" />
                            <Vertex pos="4 -2 6" />
                            <Vertex pos="6 -2 -6" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-6 2 -6" />
                            <Vertex pos="-2 -2 6" />
                            <Vertex pos="-6 -2 -6" />
                        </Vertices>
                        <Face id="0" plane="0.986394 -0 0.164399 -4.93197" album="" material="bm_grid_blank4" texgens="0 1 0 -4608 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0 0.316228 -3.79473" album="" material="bm_tile09_A" texgens="0 -1 0 0 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -4096 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 4352 0 -1 0 4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="13 -37 34" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -37 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 44" />
                            <Vertex pos="1 1 -44" />
                            <Vertex pos="1.5 -1 44" />
                            <Vertex pos="1.5 -1 -44" />
                            <Vertex pos="-1 1 44" />
                            <Vertex pos="-1 1 -44" />
                            <Vertex pos="-1 -1 44" />
                            <Vertex pos="-1 -1 -44" />
                        </Vertices>
                        <Face id="0" plane="0.970142 0.242536 0 -1.21268" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -44" album="" material="bm_tile09_A" texgens="1 0 0 -1280 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -44" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-13 -33 38" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -33 0 0 1 38 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 48" />
                            <Vertex pos="1 3 -48" />
                            <Vertex pos="1 -3 46" />
                            <Vertex pos="1 -3 -48" />
                            <Vertex pos="-1 3 48" />
                            <Vertex pos="-1 3 -48" />
                            <Vertex pos="-1 -3 46" />
                            <Vertex pos="-1 -3 -48" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.316228 0.948683 -44.5881" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -48" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-13 -26 68.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -26 0 0 1 68.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 23.25" />
                            <Vertex pos="1 2 -23.25" />
                            <Vertex pos="1 -2 23.25" />
                            <Vertex pos="1 -2 -23.25" />
                            <Vertex pos="-1 2 23.25" />
                            <Vertex pos="-1 2 -23.25" />
                            <Vertex pos="-1 -2 23.25" />
                            <Vertex pos="-1 -2 -23.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23.25" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="2 -26 97" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -26 0 0 1 97 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13" />
                            <Vertex pos="2 2 -9" />
                            <Vertex pos="2 -2 13" />
                            <Vertex pos="2 -2 -13" />
                            <Vertex pos="-2 2 13" />
                            <Vertex pos="-2 2 -9" />
                            <Vertex pos="-2 -2 13" />
                            <Vertex pos="-2 -2 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile09_A" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -7.77817" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-28 -11 17" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -11 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 5 27" />
                            <Vertex pos="12 5 -27" />
                            <Vertex pos="12 -5 27" />
                            <Vertex pos="12 -5 -27" />
                            <Vertex pos="-12 5 27" />
                            <Vertex pos="-12 5 -27" />
                            <Vertex pos="-12 -5 27" />
                            <Vertex pos="-12 -5 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-28 -4 37" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -4 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 2 7" />
                            <Vertex pos="12 2 -7" />
                            <Vertex pos="12 -2 7" />
                            <Vertex pos="12 -2 -7" />
                            <Vertex pos="-12 2 7" />
                            <Vertex pos="-12 2 -7" />
                            <Vertex pos="-12 -2 7" />
                            <Vertex pos="-12 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3328 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3072 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -3072 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 3328 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-39 -4 8" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -4 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 17" />
                            <Vertex pos="1 2 -18" />
                            <Vertex pos="1 -2 17" />
                            <Vertex pos="1 -2 -18" />
                            <Vertex pos="-1 2 18" />
                            <Vertex pos="-1 2 -18" />
                            <Vertex pos="-1 -2 18" />
                            <Vertex pos="-1 -2 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -15.6525" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="0 -6.99999 48" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -6.99999 0 0 1 48 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.99999 2.99999 2" />
                            <Vertex pos="16 9.00001 -2" />
                            <Vertex pos="9.99999 -9.00001 2" />
                            <Vertex pos="16 -9.00001 -2" />
                            <Vertex pos="-9.99999 2.99999 2" />
                            <Vertex pos="-16 9.00001 -2" />
                            <Vertex pos="-9.99999 -9.00001 2" />
                            <Vertex pos="-16 -9.00001 -2" />
                        </Vertices>
                        <Face id="0" plane="0.5547 -0 0.832051 -7.21109" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 383.96 0 0.25 0.166667" texRot="0" texScale="0.25 0.166667" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.5547 0 0.832051 -7.21109" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 383.96 0 0.25 0.166667" texRot="0" texScale="0.25 0.166667" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.554699 0.832051 -3.32819" album="" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 0 -1 383.96 0 0.25 0.166667" texRot="0" texScale="0.25 0.166667" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -9.00001" album="" material="bm_grid_blank4" texgens="1 0 0 -2816 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2816 0 -1 0 6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="0 0 45" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 16 1" />
                            <Vertex pos="16 16 -1" />
                            <Vertex pos="16 -16 1" />
                            <Vertex pos="16 -16 -1" />
                            <Vertex pos="-16 16 1" />
                            <Vertex pos="-16 16 -1" />
                            <Vertex pos="-16 -16 1" />
                            <Vertex pos="-16 -16 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -16" album="" material="bm_grid_blank4" texgens="0 1 0 -3840 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -16" album="" material="bm_grid_blank4" texgens="0 -1 0 4096 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-28 -3 45" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -3 0 0 1 45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 13 1" />
                            <Vertex pos="12 13 -1" />
                            <Vertex pos="12 -13 1" />
                            <Vertex pos="12 -13 -1" />
                            <Vertex pos="-12 13 1" />
                            <Vertex pos="-12 13 -1" />
                            <Vertex pos="-12 -13 1" />
                            <Vertex pos="-12 -13 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -4224 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 4480 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1792 0 -1 0 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-28 -3 52" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -3 0 0 1 52 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="12 13 -6" />
                            <Vertex pos="4 -5 6" />
                            <Vertex pos="12 -13 -6" />
                            <Vertex pos="-4 5 6" />
                            <Vertex pos="-12 13 -6" />
                            <Vertex pos="-4 -5 6" />
                            <Vertex pos="-12 -13 -6" />
                        </Vertices>
                        <Face id="0" plane="0.83205 -0 0.5547 -6.6564" album="" material="bm_grid_blank4" texgens="0 1 0 -4224 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.83205 0 0.5547 -6.6564" album="" material="bm_grid_blank4" texgens="0 -1 0 4480 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.83205 0.5547 -7.48845" album="" material="bm_grid_blank4" texgens="-1 0 0 1792 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.83205 0.5547 -7.48845" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 1792 0 -1 0 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-28 -3 65" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -3 0 0 1 65 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.999997 7" />
                            <Vertex pos="4 5 -7.00001" />
                            <Vertex pos="2 -3 7" />
                            <Vertex pos="4 -5 -7.00001" />
                            <Vertex pos="-2 0.999997 7" />
                            <Vertex pos="-4 5 -7.00001" />
                            <Vertex pos="-2 -3 7" />
                            <Vertex pos="-4 -5 -7.00001" />
                        </Vertices>
                        <Face id="0" plane="0.989949 -0 0.141421 -2.96985" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.98995 0 0.141421 -2.96985" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.961524 0.274721 -2.88457" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.989949 0.141421 -3.9598" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.00001" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="0 9 50" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 9 0 0 1 50 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 3 4" />
                            <Vertex pos="16 7 -4" />
                            <Vertex pos="8 -1 4" />
                            <Vertex pos="16 -7 -4" />
                            <Vertex pos="-8 3 4" />
                            <Vertex pos="-16 7 -4" />
                            <Vertex pos="-8 -1 4" />
                            <Vertex pos="-16 -7 -4" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -8.48528" album="" material="bm_grid_blank4" texgens="0 1 0 -5248 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -8.48528" album="" material="bm_grid_blank4" texgens="0 -1 0 5504 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -4.47214" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.8 0.6 -3.2" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 -1 0 5504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 5504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-3.33786e-006 10 62" rot="1 0 0 0" scale="" transform="1 0 0 -3.33786e-006 0 1 0 10 0 0 1 62 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 1 7.99999" />
                            <Vertex pos="8 2 -7.99999" />
                            <Vertex pos="2.00001 -1 7.99999" />
                            <Vertex pos="8 -2 -7.99999" />
                            <Vertex pos="-4 1 7.99999" />
                            <Vertex pos="-8 2 -7.99999" />
                            <Vertex pos="-4 -1 7.99999" />
                            <Vertex pos="-8 -2 -7.99999" />
                        </Vertices>
                        <Face id="0" plane="0.936329 -0 0.351123 -4.68165" album="" material="bm_grid_blank4" texgens="0 1 0 -5120 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0 0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="0 -1 0 5376 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.998053 0.0623784 -1.49708" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.998053 0.0623784 -1.49708" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.99999" album="" material="bm_grid_blank4" texgens="1 0 0 -0.000427246 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="4 20 6.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 20 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2.5 -2.5 16.75" />
                            <Vertex pos="2.5 -2.5 -16.75" />
                            <Vertex pos="0 1.5 16.75" />
                            <Vertex pos="0 1.5 -16.75" />
                            <Vertex pos="-2 -2 16.75" />
                            <Vertex pos="-2 -2 -16.75" />
                        </Vertices>
                        <Face id="0" plane="0.993884 0.110432 0 -2.20863" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.868243 0.496139 0 -0.744208" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 -1.45521" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.110432 -0.993884 -0 -2.20863" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="16 -105 16" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -105 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 26" />
                            <Vertex pos="2 1 -26" />
                            <Vertex pos="1.5 -1 26" />
                            <Vertex pos="1.5 -1 -26" />
                            <Vertex pos="-2 1 26" />
                            <Vertex pos="-2 1 -26" />
                            <Vertex pos="-2 -2.99999 26" />
                            <Vertex pos="-2 -2.99999 -26" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -1.69775" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.496137 -0.868244 0 -1.61245" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -26" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-13 -44 29" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -44 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 -8 39" />
                            <Vertex pos="1 -8 -39" />
                            <Vertex pos="1 8 39" />
                            <Vertex pos="1 8 -39" />
                            <Vertex pos="-1 8 39" />
                            <Vertex pos="-1 8 -39" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.992278 -0.124035 -0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -39" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-8.5 -48 73" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 -48 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 4 5" />
                            <Vertex pos="4.5 4 -5" />
                            <Vertex pos="4.5 -4 -1" />
                            <Vertex pos="4.5 -4 -5" />
                            <Vertex pos="-4.5 4 5" />
                            <Vertex pos="-4.5 4 -5" />
                            <Vertex pos="-3.5 -4 -1" />
                            <Vertex pos="-3.5 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 -0.124035 0 -3.96911" album="" material="bm_grid_blank4" texgens="0 -1 0 2560 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2624 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -2368 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -1.6" album="" material="bm_grid_blank4" texgens="1 0 0 -2368 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2624 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="5 -46 73" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -46 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 2 5" />
                            <Vertex pos="9 2 -5" />
                            <Vertex pos="7 -2 2" />
                            <Vertex pos="7 -2 -5" />
                            <Vertex pos="-9 2 5" />
                            <Vertex pos="-9 2 -5" />
                            <Vertex pos="-9 -2 2" />
                            <Vertex pos="-9 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -2.8" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="13 -46 29" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -46 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 -2 39" />
                            <Vertex pos="-1 -2 -39" />
                            <Vertex pos="1 2 39" />
                            <Vertex pos="1 2 -39" />
                            <Vertex pos="-1 2 39" />
                            <Vertex pos="-1 2 -39" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -0" album="" material="bm_grid_blank4" texgens="0 1 0 -5632 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 -0 -0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 5888 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 -1 0 5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-1 -26 73" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -26 0 0 1 73 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 5" />
                            <Vertex pos="1 2 -5" />
                            <Vertex pos="1 -2 5" />
                            <Vertex pos="1 -2 -5" />
                            <Vertex pos="-1 2 5" />
                            <Vertex pos="-1 2 -5" />
                            <Vertex pos="-1 -2 5" />
                            <Vertex pos="-1 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 -1280 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="2 -27 78" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -27 0 0 1 78 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2 1 7.99999" />
                            <Vertex pos="-2 0.999998 -10" />
                            <Vertex pos="-2 -1 10" />
                            <Vertex pos="-2 -1 -10" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -10" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.447214 0.894427 0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0.333333 0.666669 0.666665 -5.33332" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="15 -30.25 22" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -30.25 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 8.25 28" />
                            <Vertex pos="3 8.25 -32" />
                            <Vertex pos="3 -7.25 28" />
                            <Vertex pos="3 -7.25 -32" />
                            <Vertex pos="-3 11.25 32" />
                            <Vertex pos="-3 11.25 -32" />
                            <Vertex pos="-3 -11.25 32" />
                            <Vertex pos="-3 -11.25 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1312 0 0 -1 6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1568 0 0 -1 6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -8.72066" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.5547 -0.83205 0 -7.69647" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.5547 0 0.83205 -24.9615" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 1568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="17 -24.75 14" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -24.75 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 6.74999 20" />
                            <Vertex pos="5 6.74999 -24" />
                            <Vertex pos="5 -6.75 20" />
                            <Vertex pos="5 -6.75 -24" />
                            <Vertex pos="-5 10.75 24" />
                            <Vertex pos="-5 10.75 -24" />
                            <Vertex pos="-5 -10.75 24" />
                            <Vertex pos="-5 -10.75 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1376 0 0 -1 7168 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 1632 0 0 -1 7168 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.371392 0.928476 -0 -8.12416" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 7168 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.371391 -0.928477 0 -8.12417" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 7168 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.371391 0 0.928477 -20.4265" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 -1 0 352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-23 -4 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -4 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 17.25" />
                            <Vertex pos="1 2 -17.25" />
                            <Vertex pos="1 -2 17.25" />
                            <Vertex pos="1 -2 -17.25" />
                            <Vertex pos="-1 2 17.25" />
                            <Vertex pos="-1 2 -17.25" />
                            <Vertex pos="-1 -2 17.25" />
                            <Vertex pos="-1 -2 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.25" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-27 -2 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -2 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 16.75" />
                            <Vertex pos="1 0 -17.25" />
                            <Vertex pos="1 -2 16.75" />
                            <Vertex pos="1 -2 -17.25" />
                            <Vertex pos="-0.5 0 16.75" />
                            <Vertex pos="-0.5 0 -17.25" />
                            <Vertex pos="-1 -2 16.75" />
                            <Vertex pos="-1 -2 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -0.485071" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-29 -5 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -5 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 16.75" />
                            <Vertex pos="1 1 -17.25" />
                            <Vertex pos="1 -1 16.75" />
                            <Vertex pos="1 -1 -17.25" />
                            <Vertex pos="0 1 16.25" />
                            <Vertex pos="0 1 -17.25" />
                            <Vertex pos="0 -1 16.25" />
                            <Vertex pos="0 -1 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -14.5344" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-31 -4 6" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 -4 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 16" />
                            <Vertex pos="1 2 -16" />
                            <Vertex pos="1 -2 16" />
                            <Vertex pos="1 -2 -16" />
                            <Vertex pos="-1 2 16" />
                            <Vertex pos="-1 2 -16" />
                            <Vertex pos="-1 -2 16" />
                            <Vertex pos="-1 -2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_bounce_low" texgens="1 0 0 -256 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-35 -5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 16.5" />
                            <Vertex pos="1 1 -17.5" />
                            <Vertex pos="1 -1 16.5" />
                            <Vertex pos="1 -1 -17.5" />
                            <Vertex pos="-1 1 17.5" />
                            <Vertex pos="-1 1 -17.5" />
                            <Vertex pos="-1 -1 17.5" />
                            <Vertex pos="-1 -1 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -15.2053" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-37 -3 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -3 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 17.5" />
                            <Vertex pos="1 1 -17.5" />
                            <Vertex pos="1 -1 17.5" />
                            <Vertex pos="1 -1 -17.5" />
                            <Vertex pos="-1 1 17.5" />
                            <Vertex pos="-1 1 -17.5" />
                            <Vertex pos="-1 -1 17.5" />
                            <Vertex pos="-1 -1 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.5" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="13 -18.5 21" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -18.5 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2.5 25" />
                            <Vertex pos="3 2.5 -29" />
                            <Vertex pos="3 -2.5 25" />
                            <Vertex pos="3 -2.5 -29" />
                            <Vertex pos="-3 2.5 29" />
                            <Vertex pos="-3 2.5 -29" />
                            <Vertex pos="-3 -2.5 29" />
                            <Vertex pos="-3 -2.5 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1728 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -1472 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.5547 0 0.83205 -22.4654" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 -1 0 -1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 -1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-13 -25 21" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -25 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 9 29" />
                            <Vertex pos="3 9 -31" />
                            <Vertex pos="3 -9 29" />
                            <Vertex pos="3 -9 -31" />
                            <Vertex pos="-3 9 25" />
                            <Vertex pos="-3 9 -31" />
                            <Vertex pos="-3 -3 25" />
                            <Vertex pos="-3 -3 -31" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.24264" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.5547 0 0.83205 -22.4654" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -31" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="1 -36 125" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -36 0 0 1 125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999995 4 11" />
                            <Vertex pos="7 4 -11" />
                            <Vertex pos="-0.999994 0 11" />
                            <Vertex pos="7 -4 -11" />
                            <Vertex pos="-5 4 11" />
                            <Vertex pos="-7 4 -11" />
                            <Vertex pos="-5 0 11" />
                            <Vertex pos="-7 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="0.939794 2.38068e-007 0.341743 -2.81938" album="" material="bm_grid_blank4" texgens="0 1 0 -4864 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.995893 0 0.0905358 -5.97536" album="" material="bm_grid_blank4" texgens="0 -1 0 5120 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 3456 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.98387 0.178885 -1.96774" album="" material="bm_grid_blank4" texgens="1 0 0 -3200 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_tile09_A" texgens="1 0 0 -1280 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 3456 0 -1 0 5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-3 -30 121" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -30 0 0 1 121 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.66893e-006 3.8147e-006 6.99999" />
                            <Vertex pos="1.90735e-006 -2 6.99999" />
                            <Vertex pos="2.99999 2 -6.99999" />
                            <Vertex pos="3 -2 -6.99999" />
                            <Vertex pos="-2.99999 2 -6.99999" />
                            <Vertex pos="-3 -2 -6.99999" />
                        </Vertices>
                        <Face id="0" plane="0.977802 1.16564e-007 0.209529 -1.4667" album="" material="bm_grid_blank4" texgens="0 1 0 -5120 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.977802 2.44783e-006 0.209529 -1.4667" album="" material="bm_grid_blank4" texgens="0 -1 0 5376 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.989949 0.141421 -0.989951" album="" material="bm_grid_blank4" texgens="-1 0 0 3968 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -6.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 3968 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="4" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3712 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="7 -41 75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 -41 0 0 1 75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7" />
                            <Vertex pos="1 1 -7" />
                            <Vertex pos="1 -1 7" />
                            <Vertex pos="1 -1 -7" />
                            <Vertex pos="-0.5 1 7" />
                            <Vertex pos="-0.5 1 -7" />
                            <Vertex pos="-1 -1 7" />
                            <Vertex pos="-1 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -0.727607" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="2.5 -39 75.25" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -39 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 7.25" />
                            <Vertex pos="0.5 1 -7.25" />
                            <Vertex pos="0.5 -1 7.25" />
                            <Vertex pos="0.5 -1 -7.25" />
                            <Vertex pos="-1 1 7.25" />
                            <Vertex pos="-1 1 -7.25" />
                            <Vertex pos="-0.5 -1 7.25" />
                            <Vertex pos="-0.5 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 -0.242536 0 -0.727607" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1216 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.25" album="" material="bm_tile09_A" texgens="1 0 0 1152 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="3.5 -39 75.25" rot="1 0 0 0" scale="" transform="1 0 0 3.5 0 1 0 -39 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 6.75001" />
                            <Vertex pos="0.5 1 -7.25" />
                            <Vertex pos="0.5 -1 6.75001" />
                            <Vertex pos="0.5 -1 -7.25" />
                            <Vertex pos="-0.5 1 7.25001" />
                            <Vertex pos="-0.5 1 -7.25" />
                            <Vertex pos="-0.5 -1 7.25001" />
                            <Vertex pos="-0.5 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 192 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -6.261" album="" material="bm_tile09_A" texgens="1 0 0 384 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-1 -39 75.25" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -39 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7.25" />
                            <Vertex pos="1 1 -7.25" />
                            <Vertex pos="1 -1 7.25" />
                            <Vertex pos="1 -1 -7.25" />
                            <Vertex pos="-1 1 7.25" />
                            <Vertex pos="-1 1 -7.25" />
                            <Vertex pos="-1 -1 7.25" />
                            <Vertex pos="-1 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.25" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-1 -41 75.25" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -41 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7.25" />
                            <Vertex pos="1 1 -7.25" />
                            <Vertex pos="1 -1 7.25" />
                            <Vertex pos="1 -1 -7.25" />
                            <Vertex pos="-1 1 7.25" />
                            <Vertex pos="-1 1 -7.25" />
                            <Vertex pos="-2 -1 7.25" />
                            <Vertex pos="-2 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -1.34164" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.25" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-5 -41 75.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -41 0 0 1 75.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 6.75001" />
                            <Vertex pos="1 1 -7.75" />
                            <Vertex pos="1 -1 6.75001" />
                            <Vertex pos="1 -1 -7.75" />
                            <Vertex pos="-1 1 7.75001" />
                            <Vertex pos="-1 1 -7.75" />
                            <Vertex pos="-1 -1 7.75001" />
                            <Vertex pos="-1 -1 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -6.48461" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-7 -41 75.75" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -41 0 0 1 75.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7.75" />
                            <Vertex pos="1 1 -7.75" />
                            <Vertex pos="1 -1 7.75" />
                            <Vertex pos="1 -1 -7.75" />
                            <Vertex pos="-1 1 7.75" />
                            <Vertex pos="-1 1 -7.75" />
                            <Vertex pos="-1 -1 7.75" />
                            <Vertex pos="-1 -1 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-9.5 -40 76" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -40 0 0 1 76 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 7.49999" />
                            <Vertex pos="0.5 2 -8" />
                            <Vertex pos="0.5 -2 7.49999" />
                            <Vertex pos="0.5 -2 -8" />
                            <Vertex pos="-0.5 2 7.99999" />
                            <Vertex pos="-0.5 2 -8" />
                            <Vertex pos="-0.5 -2 7.99999" />
                            <Vertex pos="-0.5 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1216 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -6.9318" album="" material="bm_tile09_A" texgens="1 0 0 1152 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 1472 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-13 -15 10" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -15 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 18" />
                            <Vertex pos="1 1 -18" />
                            <Vertex pos="1 -1 18" />
                            <Vertex pos="1 -1 -18" />
                            <Vertex pos="-1 1 18" />
                            <Vertex pos="-1 1 -18" />
                            <Vertex pos="-1 -1 18" />
                            <Vertex pos="-1 -1 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-11 -15 -0.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -15 0 0 1 -0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7.25" />
                            <Vertex pos="1 1 -7.25" />
                            <Vertex pos="1 -1 7.25" />
                            <Vertex pos="1 -1 -7.25" />
                            <Vertex pos="-1 1 7.25" />
                            <Vertex pos="-1 1 -7.25" />
                            <Vertex pos="-1 -1 7.25" />
                            <Vertex pos="-1 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.25" album="" material="bm_tile10_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-11 -15 21" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -15 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 7" />
                            <Vertex pos="1 1 -7" />
                            <Vertex pos="1 -1 7" />
                            <Vertex pos="1 -1 -7" />
                            <Vertex pos="-1 1 7" />
                            <Vertex pos="-1 1 -7" />
                            <Vertex pos="-1 -1 7" />
                            <Vertex pos="-1 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-11 -15 12" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -15 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 -1 2" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                        <Face id="2" plane="0 0.894427 -0.447214 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-28 9 17" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 9 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 27" />
                            <Vertex pos="12 1 -27" />
                            <Vertex pos="12 -1 27" />
                            <Vertex pos="12 -1 -27" />
                            <Vertex pos="-12 1 27" />
                            <Vertex pos="-12 1 -27" />
                            <Vertex pos="-12 -1 27" />
                            <Vertex pos="-12 -1 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 1024 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 1536 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-39 7 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 7 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 21.25" />
                            <Vertex pos="1 1 -21.25" />
                            <Vertex pos="1 -1 21.25" />
                            <Vertex pos="1 -1 -21.25" />
                            <Vertex pos="-1 1 21.25" />
                            <Vertex pos="-1 1 -21.25" />
                            <Vertex pos="-1 -1 21.25" />
                            <Vertex pos="-1 -1 -21.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -2208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 -2208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 -2208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 -2208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21.25" album="" material="bm_tile10_A" texgens="1 0 0 -1792 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="-27 7 17" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 7 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11 1 27" />
                            <Vertex pos="11 1 -27" />
                            <Vertex pos="11 -1 27" />
                            <Vertex pos="11 -1 -27" />
                            <Vertex pos="-11 1 27" />
                            <Vertex pos="-11 1 -27" />
                            <Vertex pos="-11 -1 27" />
                            <Vertex pos="-11 -1 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -11" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -11" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile10_A" texgens="1 0 0 1280 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-39 7 38" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 7 0 0 1 38 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="-0.999996 1 2" />
                            <Vertex pos="-0.999996 -1 2" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894428 0 -0.447213 1.78814e-006" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 1" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile10_A" texgens="1 0 0 -1792 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="-39 7 42" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 7 0 0 1 42 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2432 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2688 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile10_A" texgens="1 0 0 -1792 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="-5 -27 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -27 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 27.25" />
                            <Vertex pos="1 1 -25.25" />
                            <Vertex pos="1 -1 27.25" />
                            <Vertex pos="1 -1 -25.25" />
                            <Vertex pos="-1 1 27.25" />
                            <Vertex pos="-1 1 -25.25" />
                            <Vertex pos="-1 -1 27.25" />
                            <Vertex pos="-1 -1 -25.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27.25" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -25.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="-8 -21 29" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -21 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5 39" />
                            <Vertex pos="4 5 -39" />
                            <Vertex pos="4 -5 39" />
                            <Vertex pos="4 -5 -39" />
                            <Vertex pos="-4 5 39" />
                            <Vertex pos="-4 5 -39" />
                            <Vertex pos="-4 -5 39" />
                            <Vertex pos="-4 -5 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -5760 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 6016 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-9 -27 29" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -27 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 39" />
                            <Vertex pos="3 1 -39" />
                            <Vertex pos="3 -1 39" />
                            <Vertex pos="3 -1 -39" />
                            <Vertex pos="-3 1 39" />
                            <Vertex pos="-3 1 -39" />
                            <Vertex pos="-3 -1 39" />
                            <Vertex pos="-3 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2688 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_tile10_A" texgens="1 0 0 -1792 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2944 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-5 -27 48" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -27 0 0 1 48 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 -2" />
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 -1 2" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0 -0.447214 -0" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="3" plane="-0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 1" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-5 -27 58" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -27 0 0 1 58 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 10" />
                            <Vertex pos="1 1 -8" />
                            <Vertex pos="1 -1 10" />
                            <Vertex pos="1 -1 -8" />
                            <Vertex pos="-1 1 10" />
                            <Vertex pos="-1 1 -8" />
                            <Vertex pos="-1 -1 10" />
                            <Vertex pos="-1 -1 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="8 -47 29" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -47 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 39" />
                            <Vertex pos="4 1 -39" />
                            <Vertex pos="4 -1 39" />
                            <Vertex pos="4 -1 -39" />
                            <Vertex pos="-4 1 39" />
                            <Vertex pos="-4 1 -39" />
                            <Vertex pos="-4 -1 39" />
                            <Vertex pos="-4 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="5 -45 59" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -45 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 9" />
                            <Vertex pos="1 1 -31" />
                            <Vertex pos="1 -1 9" />
                            <Vertex pos="1 -1 -31" />
                            <Vertex pos="-1 1 9" />
                            <Vertex pos="-1 1 -31" />
                            <Vertex pos="-1 -1 9" />
                            <Vertex pos="-1 -1 -31" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -31" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="9 -45 29" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -45 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 39" />
                            <Vertex pos="3 1 -39" />
                            <Vertex pos="3 -1 39" />
                            <Vertex pos="3 -1 -39" />
                            <Vertex pos="-3 1 39" />
                            <Vertex pos="-3 1 -39" />
                            <Vertex pos="-3 -1 39" />
                            <Vertex pos="-3 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -39" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-4.75 -39 75.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -39 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1 7.25" />
                            <Vertex pos="0.75 1 -7.25" />
                            <Vertex pos="0.75 -1 7.25" />
                            <Vertex pos="0.75 -1 -7.25" />
                            <Vertex pos="-0.25 1 7.25" />
                            <Vertex pos="-0.25 1 -7.25" />
                            <Vertex pos="-0.75 -1 7.25" />
                            <Vertex pos="-0.75 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -0.485071" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1376 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1120 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.25" album="" material="bm_tile09_A" texgens="1 0 0 1344 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1376 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="22 17 14.5" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 17 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 9.5" />
                            <Vertex pos="2 1 -9.5" />
                            <Vertex pos="1 -1 9.5" />
                            <Vertex pos="1 -1 -7.5" />
                            <Vertex pos="-2 1 9.5" />
                            <Vertex pos="-2 1 -9.5" />
                            <Vertex pos="-0.999998 -1 9.5" />
                            <Vertex pos="-0.999998 -1 -7.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="0 1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.5" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -6.01041" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="22 23 14.5" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 23 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999998 1 9.5" />
                            <Vertex pos="0.999998 1 -7.5" />
                            <Vertex pos="2 -1 9.5" />
                            <Vertex pos="2 -1 -9.5" />
                            <Vertex pos="-0.999998 1 9.5" />
                            <Vertex pos="-0.999998 1 -7.5" />
                            <Vertex pos="-2 -1 9.5" />
                            <Vertex pos="-2 -1 -9.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="0 1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.5" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -6.01041" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="22 18.5 24.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 18.5 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 1.75" />
                            <Vertex pos="2 0.5 -0.749998" />
                            <Vertex pos="2 -0.5 1.75" />
                            <Vertex pos="2 -0.5 -1.75" />
                            <Vertex pos="-2 0.5 1.75" />
                            <Vertex pos="-2 0.5 -0.749998" />
                            <Vertex pos="-2 -0.5 1.75" />
                            <Vertex pos="-2 -0.5 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 64 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 192 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707106 -0.883882" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="22 21.5 24.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 21.5 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 1.75" />
                            <Vertex pos="2 0.5 -1.75" />
                            <Vertex pos="2 -0.5 1.75" />
                            <Vertex pos="2 -0.5 -0.75" />
                            <Vertex pos="-2 0.5 1.75" />
                            <Vertex pos="-2 0.5 -1.75" />
                            <Vertex pos="-2 -0.5 1.75" />
                            <Vertex pos="-2 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 192 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 64 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.883883" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="22 23.25 25" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 23.25 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.5 -1.25 0.999998" />
                            <Vertex pos="2.5 -1.25 -0.999998" />
                            <Vertex pos="1.5 1.25 -0.999998" />
                            <Vertex pos="-2.5 -1.25 0.999998" />
                            <Vertex pos="-2.5 -1.25 -0.999998" />
                            <Vertex pos="-1.5 1.25 -0.999998" />
                        </Vertices>
                        <Face id="0" plane="0.928477 0.371391 -0 -1.85695" album="" material="bm_grid_blank1" texgens="0 1 0 128.001 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-0.928477 0.371391 0 -1.85695" album="" material="bm_grid_blank1" texgens="0 -1 0 127.999 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1.25" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="3" plane="0 0.624694 0.780869 -0" album="" material="bm_grid_blank1" texgens="1 0 0 0.000732422 0 -1 0 127.999 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.999998" album="" material="bm_grid_blank1" texgens="-1 0 0 -0.000732422 0 -1 0 127.999 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="22 20 25.25" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 20 0 0 1 25.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1.25" />
                            <Vertex pos="2 1 -1.25" />
                            <Vertex pos="2 -1 1.25" />
                            <Vertex pos="2 -1 -1.25" />
                            <Vertex pos="-2 1 1.25" />
                            <Vertex pos="-2 1 -1.25" />
                            <Vertex pos="-2 -1 1.25" />
                            <Vertex pos="-2 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_grid_blank3_rock" texgens="1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="22 16.75 25" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 16.75 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.5 1.25 1" />
                            <Vertex pos="2.5 1.25 -1" />
                            <Vertex pos="1.5 -1.25 -1" />
                            <Vertex pos="-2.5 1.25 1" />
                            <Vertex pos="-2.5 1.25 -1" />
                            <Vertex pos="-1.5 -1.25 -1" />
                        </Vertices>
                        <Face id="0" plane="0.928477 -0.371391 0 -1.85695" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.928477 -0.371391 0 -1.85695" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 -0.624695 0.780869 -0" album="" material="bm_grid_blank1" texgens="1 0 0 0.000732422 0 -1 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -0.000732422 0 -1 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="19 -84 36.5" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 -84 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 2 6.5" />
                            <Vertex pos="-1 2 -6.5" />
                            <Vertex pos="1 1 6.5" />
                            <Vertex pos="1 1 -4.5" />
                            <Vertex pos="-1 -1.99999 6.5" />
                            <Vertex pos="-1 -1.99999 -6.5" />
                            <Vertex pos="1 -0.999992 6.5" />
                            <Vertex pos="1 -0.999992 -4.5" />
                        </Vertices>
                        <Face id="0" plane="0.447214 0.894427 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.447213 -0.894428 0 -1.34163" album="" material="bm_grid_blank3_rock" texgens="1 0 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -6.5" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 1 0 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -3.88909" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 1 0 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="13 -84 36.5" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -84 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 1 6.5" />
                            <Vertex pos="-1 1 -4.5" />
                            <Vertex pos="1 2 6.5" />
                            <Vertex pos="1 2 -6.5" />
                            <Vertex pos="-1 -1 6.5" />
                            <Vertex pos="-1 -1 -4.5" />
                            <Vertex pos="1 -2 6.5" />
                            <Vertex pos="1 -2 -6.5" />
                        </Vertices>
                        <Face id="0" plane="-0.447214 0.894427 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 -0.894427 0 -1.34164" album="" material="bm_grid_blank3_rock" texgens="1 0 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 128 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 0 0 -1 -1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 1 0 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -3.88909" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 1 0 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="17.5 -84 43.75" rot="1 0 0 0" scale="" transform="1 0 0 17.5 0 1 0 -84 0 0 1 43.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 2 1.75" />
                            <Vertex pos="-0.5 2 -0.75" />
                            <Vertex pos="0.5 2 1.75" />
                            <Vertex pos="0.5 2 -1.75" />
                            <Vertex pos="-0.5 -2 1.75" />
                            <Vertex pos="-0.5 -2 -0.75" />
                            <Vertex pos="0.5 -2 1.75" />
                            <Vertex pos="0.5 -2 -1.75" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 64 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 192 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.75" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 1 0 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -0.883883" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 1 0 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="14.5 -84 43.75" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -84 0 0 1 43.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 2 1.75" />
                            <Vertex pos="-0.499999 2 -1.75" />
                            <Vertex pos="0.5 2 1.75" />
                            <Vertex pos="0.5 2 -0.75" />
                            <Vertex pos="-0.5 -2 1.75" />
                            <Vertex pos="-0.499999 -2 -1.75" />
                            <Vertex pos="0.5 -2 1.75" />
                            <Vertex pos="0.5 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 192 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 64 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-1 -0 -2.89508e-007 -0.499999" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 0 0 -1 -2016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.75" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707106 -0.883883" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="12.75 -84 44" rot="1 0 0 0" scale="" transform="1 0 0 12.75 0 1 0 -84 0 0 1 44 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.25 2.49999 1" />
                            <Vertex pos="1.25 2.5 -1" />
                            <Vertex pos="-1.25 1.5 -1" />
                            <Vertex pos="1.25 -2.5 1" />
                            <Vertex pos="1.25 -2.5 -1" />
                            <Vertex pos="-1.25 -1.5 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.371391 0.928477 4.64869e-006 -1.85695" album="" material="bm_grid_blank1" texgens="-1 0 0 127.999 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-0.371391 -0.928477 -0 -1.85695" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -1.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="3" plane="-0.624695 0 0.780869 -0" album="" material="bm_grid_blank1" texgens="0 1 0 -0.00195313 1 0 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0.00195313 1 0 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="16 -84 44.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -84 0 0 1 44.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 2 1.25" />
                            <Vertex pos="-1 2 -1.25" />
                            <Vertex pos="1 2 1.25" />
                            <Vertex pos="1 2 -1.25" />
                            <Vertex pos="-1 -2 1.25" />
                            <Vertex pos="-1 -2 -1.25" />
                            <Vertex pos="1 -2 1.25" />
                            <Vertex pos="1 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -2" album="" material="bm_grid_blank3_rock" texgens="-1 0 0 256 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="" material="bm_grid_blank3_rock" texgens="1 0 0 0 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -0 0 -1" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 0 0 -1 -2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.25" album="" material="bm_grid_blank3_rock" texgens="0 1 0 256 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0 -1 -1.25" album="" material="bm_grid_blank3_rock" texgens="0 -1 0 0 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="19.25 -84 44" rot="1 0 0 0" scale="" transform="1 0 0 19.25 0 1 0 -84 0 0 1 44 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.25001 2.49999 1" />
                            <Vertex pos="-1.25001 2.49999 -1" />
                            <Vertex pos="1.25001 1.49999 -1" />
                            <Vertex pos="-1.25001 -2.49998 1" />
                            <Vertex pos="-1.25001 -2.49998 -1" />
                            <Vertex pos="1.25001 -1.49998 -1" />
                        </Vertices>
                        <Face id="0" plane="0.371388 0.928478 0 -1.85695" album="" material="bm_grid_blank1" texgens="-1 0 0 127.999 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.371388 -0.928478 0 -1.85694" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -1.25001" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 128 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.624692 -0 0.780871 -0" album="" material="bm_grid_blank1" texgens="0 1 0 -0.00195313 1 0 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0.00195313 1 0 0 128 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="22 20 29" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 20 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="6">
                        <Vertices>
                            <Vertex pos="-5.69174e-008 -5.69174e-008 2.5" />
                            <Vertex pos="-2.5 2.5 -2.5" />
                            <Vertex pos="2.5 2.5 -2.5" />
                            <Vertex pos="-2.5 -2.5 -2.5" />
                            <Vertex pos="2.5 -2.5 -2.5" />
                        </Vertices>
                        <Face id="30" plane="0 0.894427 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 0 0 0.447214 -0.894427 204.813 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="31" plane="-0.894427 0 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="0 -1 0 0 -0.447214 0 -0.894427 204.75 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="32" plane="0 -0.894427 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="1 0 0 0 0 -0.447214 -0.894427 204.75 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="33" plane="0.894427 0 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="0 1 0 0 0.447214 0 -0.894427 204.813 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="34" plane="-0 -0 -1 -2.5" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 256 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 4 2 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="16 -84 48" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -84 0 0 1 48 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="6">
                        <Vertices>
                            <Vertex pos="-5.69174e-008 -5.69174e-008 2.5" />
                            <Vertex pos="-2.5 2.5 -2.5" />
                            <Vertex pos="2.5 2.5 -2.5" />
                            <Vertex pos="-2.5 -2.5 -2.5" />
                            <Vertex pos="2.5 -2.5 -2.5" />
                        </Vertices>
                        <Face id="30" plane="0 0.894427 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 0 0 0.447214 -0.894427 204.813 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="31" plane="-0.894427 0 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="0 -1 0 0 -0.447214 0 -0.894427 204.75 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="32" plane="0 -0.894427 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="1 0 0 0 0 -0.447214 -0.894427 204.75 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="33" plane="0.894427 0 0.447214 -1.11803" album="Blasted" material="bm_grid_blank1" texgens="0 1 0 0 0.447214 0 -0.894427 204.813 0 0.3125 0.349385" texRot="0" texScale="0.3125 0.349385" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="34" plane="-0 -0 -1 -2.5" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 256 0 0.3125 0.3125" texRot="0" texScale="0.3125 0.3125" texDiv="256 256">
                            <Indices indices=" 4 2 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="-27 -4 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -4 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 16.75" />
                            <Vertex pos="1 0 -17.25" />
                            <Vertex pos="1 -2 16.75" />
                            <Vertex pos="1 -2 -17.25" />
                            <Vertex pos="-1 0 16.75" />
                            <Vertex pos="-1 0 -17.25" />
                            <Vertex pos="-1 -2 16.75" />
                            <Vertex pos="-1 -2 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="-25 -4 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 -4 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 17.25" />
                            <Vertex pos="1 2 -17.25" />
                            <Vertex pos="1 -2 17.25" />
                            <Vertex pos="1 -2 -17.25" />
                            <Vertex pos="-1 2 16.75" />
                            <Vertex pos="-1 2 -17.25" />
                            <Vertex pos="-1 -2 16.75" />
                            <Vertex pos="-1 -2 -17.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -16.4924" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="-37 -5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 17.5" />
                            <Vertex pos="0.5 1 -17.5" />
                            <Vertex pos="0 -1 17.5" />
                            <Vertex pos="0 -1 -17.5" />
                            <Vertex pos="-1 1 17.5" />
                            <Vertex pos="-1 1 -17.5" />
                            <Vertex pos="-1 -1 17.5" />
                            <Vertex pos="-1 -1 -17.5" />
                        </Vertices>
                        <Face id="0" plane="0.970142 -0.242536 0 -0.242536" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1920 0 0 -1 -1728 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17.5" album="" material="bm_tile10_A" texgens="1 0 0 -256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="-6 12 31.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 12 0 0 1 31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7.5" />
                            <Vertex pos="2 2 4.5" />
                            <Vertex pos="2 -2 7.5" />
                            <Vertex pos="2 -2 4.5" />
                            <Vertex pos="-2 2 7.5" />
                            <Vertex pos="-2 2 4.5" />
                            <Vertex pos="-2.5 -2 7.5" />
                            <Vertex pos="-2.5 -2 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 0.124035 0 -2.23263" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.5" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="16 -103 16.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -103 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 25.5" />
                            <Vertex pos="2 1 -26.5" />
                            <Vertex pos="2 -1 25.5" />
                            <Vertex pos="2 -1 -26.5" />
                            <Vertex pos="-2 1 25.5" />
                            <Vertex pos="-2 1 -26.5" />
                            <Vertex pos="-2 -1 25.5" />
                            <Vertex pos="-2 -1 -26.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25.5" album="" material="bm_tile10_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="-3 -15 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -15 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1" />
                            <Vertex pos="1 3 -1" />
                            <Vertex pos="3 1 1" />
                            <Vertex pos="3 1 -1" />
                            <Vertex pos="-1 3 1" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.82843" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="-3 -17 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -17 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 1" />
                            <Vertex pos="3 3 -1" />
                            <Vertex pos="3 1 1" />
                            <Vertex pos="3 1 -1" />
                            <Vertex pos="-1 3 1" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="-3 -19 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -19 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 3 2.5" />
                            <Vertex pos="7 3 -1" />
                            <Vertex pos="7 -1 2.5" />
                            <Vertex pos="7 -1 -1" />
                            <Vertex pos="-1 3 1" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.184289 0 0.982872 -1.16716" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="-3 -23 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -23 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 3 2.5" />
                            <Vertex pos="7 3 -1" />
                            <Vertex pos="7 -1 2.5" />
                            <Vertex pos="7 -1 -1" />
                            <Vertex pos="-1 3 3" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0623783 0 0.998053 -2.93178" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="-1 -25 39" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -25 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 3" />
                            <Vertex pos="5 1 -1" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -1" />
                            <Vertex pos="3 1 3" />
                            <Vertex pos="3 1 -1" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -4.02492" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-3 -29 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -29 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 3" />
                            <Vertex pos="5 1 -1" />
                            <Vertex pos="5 -3 2" />
                            <Vertex pos="5 -3 -1" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -2.66789" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-3 -35 37" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -35 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 1" />
                            <Vertex pos="5 0.5 -1" />
                            <Vertex pos="5 -3 1" />
                            <Vertex pos="5 -3 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -3" />
                            <Vertex pos="-1 -3 1" />
                            <Vertex pos="-1 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0830455 0.996546 -0 -0.9135" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.316228 0 -0.948683 -2.52982" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="-3 -45 39" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -45 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -1" />
                            <Vertex pos="7 -3 3" />
                            <Vertex pos="7 -3 -3" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -2.18282" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -1.34164" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="10 -51 14" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -51 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.999996 26" />
                            <Vertex pos="2 1 -24" />
                            <Vertex pos="2 -1 26" />
                            <Vertex pos="2 -1 -24" />
                            <Vertex pos="-6 1.5 24" />
                            <Vertex pos="-6 1.5 -24" />
                            <Vertex pos="-6 -1 24" />
                            <Vertex pos="-6 -1 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0623783 0.998053 7.97147e-008 -1.12281" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -24.7386" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -1024 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="11 -48 41" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -48 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 -1" />
                            <Vertex pos="1 0 -3" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="1 -2 -3" />
                            <Vertex pos="-7 0 1" />
                            <Vertex pos="-7 0 -1" />
                            <Vertex pos="-7 -2 1" />
                            <Vertex pos="-7 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 0.727607" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -2.66789" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="-3 -33 41" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -33 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2.5" />
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 -7 2.5" />
                            <Vertex pos="1 -7 1" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 -7 3" />
                            <Vertex pos="-1 -7 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -2432 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -2.66789" album="" material="bm_tile10_A" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1" album="" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="3 -41 75.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -41 0 0 1 75.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 6.75" />
                            <Vertex pos="1 1 -7.25" />
                            <Vertex pos="1 -1 6.75" />
                            <Vertex pos="1 -1 -7.25" />
                            <Vertex pos="-0.5 1 6.75" />
                            <Vertex pos="-0.5 1 -7.25" />
                            <Vertex pos="0 -1 6.75" />
                            <Vertex pos="0 -1 -7.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1664 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 -0.242536 0 -0.242536" album="" material="bm_grid_blank4" texgens="0 -1 0 1920 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1152 0 0 -1 -672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.75" album="" material="bm_tile09_A" texgens="1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="-12 -14 57" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -14 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 2 -7" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -7" />
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 -7" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="4 -14 57" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -14 0 0 1 57 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 2 -7" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -7" />
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 -7" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="339" owner="0" type="0" pos="10.046 -14 57.4124" rot="-1 0 0 1.5708" scale="" transform="1 0 0 10.046 0 5.96046e-008 -1 -14 0 1 5.96046e-008 57.4124 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.6109 1.41421 -2" />
                            <Vertex pos="-1.21751 1.7592 -2" />
                            <Vertex pos="-1.21751 1.7592 2" />
                            <Vertex pos="-1.6109 1.41421 2" />
                            <Vertex pos="-0.0459426 0.58763 2" />
                            <Vertex pos="-0.976645 0.58763 2" />
                            <Vertex pos="-0.976645 0.58763 -2" />
                            <Vertex pos="-0.0459426 0.58763 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.659342 0.751843 0 -2.1254" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 350.712 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.707106 -0.707107 0 12.257 -0.659347 0.751839 0 59.7129 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1285.88 0 -1 0 -7348.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.707108 0.707106 -0 -0.38303" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.707107 -0.707106 0 195.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.793354 -0.60876 -0 -0.4171" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.707107 -0.707106 0 195.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 0.58763" album="" material="bm_grid_blank4" texgens="-1 0 0 12.257 0 0 1 59.7129 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="341" owner="0" type="0" pos="9.43504 -14 56.9492" rot="-1 0 0 1.5708" scale="" transform="1 0 0 9.43504 0 5.96046e-008 -1 -14 0 1 5.96046e-008 56.9492 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.43505 1.5867 -2" />
                            <Vertex pos="-0.999996 1.8774 -2" />
                            <Vertex pos="-0.999996 1.8774 2" />
                            <Vertex pos="-1.43505 1.5867 2" />
                            <Vertex pos="-0.365736 1.05081 2" />
                            <Vertex pos="-1.12565 1.05081 2" />
                            <Vertex pos="-1.12565 1.05081 -2" />
                            <Vertex pos="-0.365736 1.05081 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.555579 0.831464 0 -2.11657" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 538.519 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.793354 -0.608761 0 11.1851 -0.555564 0.831474 0 59.9957 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1207.69 0 -1 0 -7289.5 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.793356 0.608758 -0 -0.349531" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.608761 -0.793354 0 195.142 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.866023 -0.500005 -0 -0.449429" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.608761 -0.793354 0 195.142 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.05081" album="" material="bm_grid_blank4" texgens="-1 0 0 11.1851 0 0 1 59.9957 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="343" owner="0" type="0" pos="8.76536 -14 56.5724" rot="-1 0 0 1.5708" scale="" transform="1 0 0 8.76536 0 5.96046e-008 -1 -14 0 1 5.96046e-008 56.5724 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.23463 1.73206 -2" />
                            <Vertex pos="-0.765362 1.96347 -2" />
                            <Vertex pos="-0.765362 1.96347 2" />
                            <Vertex pos="-1.23463 1.73206 2" />
                            <Vertex pos="-0.455966 1.42758 2" />
                            <Vertex pos="-1.10851 1.42758 2" />
                            <Vertex pos="-1.10851 1.42758 -2" />
                            <Vertex pos="-0.455966 1.42758 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.442277 0.896878 0 -2.0995" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 569.147 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.866027 -0.499998 0 10.2049 -0.442287 0.896873 0 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1121.97 0 -1 0 -7241.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.866026 0.5 -0 -0.318911" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.499998 -0.866027 0 194.659 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.923879 -0.382684 -0 -0.477817" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.499998 -0.866027 0 194.659 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.42758" album="" material="bm_grid_blank4" texgens="-1 0 0 10.2049 0 0 1 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="345" owner="0" type="0" pos="8.04836 -14 56.2885" rot="-1 0 0 1.5708" scale="" transform="1 0 0 8.04836 0 5.96046e-008 -1 -14 0 1 5.96046e-008 56.2885 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.0131 1.84775 -2" />
                            <Vertex pos="-0.517632 2.01595 -2" />
                            <Vertex pos="-0.517632 2.01595 2" />
                            <Vertex pos="-1.0131 1.84775 2" />
                            <Vertex pos="-0.391513 1.71147 2" />
                            <Vertex pos="-0.976578 1.71147 2" />
                            <Vertex pos="-0.976578 1.71147 -2" />
                            <Vertex pos="-0.391513 1.71147 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.321459 0.946924 0 -2.07535" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 379.723 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382681 0 9.38348 -0.321438 0.946931 0 61.3147 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1030.19 0 -1 0 -7204.93 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.92388 0.382682 -0 -0.293237" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.382681 -0.92388 0 193.939 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.965915 -0.258858 -0 -0.500263" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.382681 -0.92388 0 193.939 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.71147" album="" material="bm_grid_blank4" texgens="-1 0 0 9.38348 0 0 1 61.3147 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="347" owner="0" type="0" pos="7.29631 -14 56.1024" rot="-1 0 0 1.5708" scale="" transform="1 0 0 7.29631 0 5.96046e-008 -1 -14 0 1 5.96046e-008 56.1024 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.77422 1.93185 -2" />
                            <Vertex pos="-0.261044 2.03393 -2" />
                            <Vertex pos="-0.261044 2.03393 2" />
                            <Vertex pos="-0.77422 1.93185 2" />
                            <Vertex pos="-0.224525 1.89763 2" />
                            <Vertex pos="-0.769715 1.89763 2" />
                            <Vertex pos="-0.769715 1.89763 -2" />
                            <Vertex pos="-0.224525 1.89763 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.195096 0.980784 0 -2.04578" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 188.182 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258816 0 8.77642 -0.195087 0.980786 0 62.2611 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -933.928 0 -1 0 -7181.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.96593 0.258802 -0 -0.274236" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.258816 -0.965927 0 193.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.991446 -0.130521 -0 -0.515449" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.258816 -0.965927 0 193.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.89763" album="" material="bm_grid_blank4" texgens="-1 0 0 8.77642 0 0 1 62.2611 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="349" owner="0" type="0" pos="6.52208 -14 56.0171" rot="-1 0 0 1.5708" scale="" transform="1 0 0 6.52208 0 5.96046e-008 -1 -14 0 1 5.96046e-008 56.0171 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.522091 1.98289 -2" />
                            <Vertex pos="1.14441e-005 2.01711 -2" />
                            <Vertex pos="1.14441e-005 2.01711 2" />
                            <Vertex pos="-0.522091 1.98289 2" />
                            <Vertex pos="0.00451622 1.98289 2" />
                            <Vertex pos="0.00451621 1.98289 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.0654026 0.997859 0 -2.01279" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 -2.20068 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.991446 -0.130523 0 8.42526 -0.0654021 0.997859 0 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -834.826 0 -1 0 -7170.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="9" plane="0.991446 0.130515 -2.53923e-009 -0.263274" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.130523 -0.991445 0 191.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 5 4 2" />
                        </Face>
                        <Face id="10" plane="0 -1 0 1.98289" album="" material="bm_grid_blank4" texgens="-1 0 0 8.42526 0 0 1 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="351" owner="0" type="0" pos="11.9829 -14 61.4779" rot="-1 0 0 1.5708" scale="" transform="1 0 0 11.9829 0 5.96046e-008 -1 -14 0 1 5.96046e-008 61.4779 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.01711 -2.98023e-007 -2" />
                            <Vertex pos="-1.98289 0.522105 -2" />
                            <Vertex pos="-1.98289 0.522105 2" />
                            <Vertex pos="-2.01711 -2.98023e-007 2" />
                            <Vertex pos="-1.9829 -0.00450465 2" />
                            <Vertex pos="-1.9829 -0.00450466 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.997859 0.0654022 0 -2.01279" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 -2.2002 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 16.7073 -0.997859 0.065402 0 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1533.81 0 -1 0 -7869.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="9" plane="-0.130541 -0.991443 -0 -0.263315" album="" material="bm_grid_blank4" texgens="0 0 -1 64 1 0 0 191.453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="10" plane="1 -1.90152e-005 4.87005e-014 1.9829" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 66.8291 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="353" owner="0" type="0" pos="11.8976 -14 60.7037" rot="-1 0 0 1.5708" scale="" transform="1 0 0 11.8976 0 5.96046e-008 -1 -14 0 1 5.96046e-008 60.7037 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.03393 0.261053 -2" />
                            <Vertex pos="-1.93185 0.774222 -2" />
                            <Vertex pos="-1.93185 0.774222 2" />
                            <Vertex pos="-2.03393 0.261053 2" />
                            <Vertex pos="-1.89763 0.769717 2" />
                            <Vertex pos="-1.89763 0.224533 2" />
                            <Vertex pos="-1.89763 0.224533 -2" />
                            <Vertex pos="-1.89763 0.769717 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.980784 0.195098 0 -2.04578" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 188.181 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.130526 -0.991445 0 16.4941 -0.980786 0.195089 0 62.2612 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1522.9 0 -1 0 -7770.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.130523 0.991445 -0 -0.515448" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.991445 -0.130526 0 192.524 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.258809 -0.965928 -0 -0.274241" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.991445 -0.130526 0 192.524 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.89763" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 165.93 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="355" owner="0" type="0" pos="11.7115 -14 59.9516" rot="-1 0 0 1.5708" scale="" transform="1 0 0 11.7115 0 5.96046e-008 -1 -14 0 1 5.96046e-008 59.9516 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.01594 0.517635 -2" />
                            <Vertex pos="-1.84776 1.0131 -2" />
                            <Vertex pos="-1.84776 1.0131 2" />
                            <Vertex pos="-2.01594 0.517635 2" />
                            <Vertex pos="-1.71147 0.976581 2" />
                            <Vertex pos="-1.71147 0.391519 2" />
                            <Vertex pos="-1.71147 0.391519 -2" />
                            <Vertex pos="-1.71147 0.976581 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.946935 0.321426 0 -2.07534" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 379.724 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.258819 -0.965926 0 16.011 -0.946931 0.321438 0 61.3146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1499.07 0 -1 0 -7673.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.258821 0.965925 -0 -0.50034" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.965926 -0.258819 0 193.505 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.382684 -0.923879 -0 -0.293237" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.965926 -0.258819 0 193.505 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.71147" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 262.191 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="357" owner="0" type="0" pos="11.4276 -14 59.2346" rot="-1 0 0 1.5708" scale="" transform="1 0 0 11.4276 0 5.96046e-008 -1 -14 0 1 5.96046e-008 59.2346 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.96347 0.765367 -2" />
                            <Vertex pos="-1.73206 1.23463 -2" />
                            <Vertex pos="-1.73206 1.23463 2" />
                            <Vertex pos="-1.96347 0.765367 2" />
                            <Vertex pos="-1.42757 1.10851 2" />
                            <Vertex pos="-1.42757 0.455967 2" />
                            <Vertex pos="-1.42757 0.455967 -2" />
                            <Vertex pos="-1.42757 1.10851 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.896876 0.442281 0 -2.0995" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 569.146 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.382684 -0.92388 0 15.2904 -0.89687 0.442295 0 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1462.73 0 -1 0 -7582.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.382673 0.923884 -0 -0.477841" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.923879 -0.382683 0 194.326 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.499998 -0.866027 -0 -0.318902" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.923879 -0.382683 0 194.326 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.42757" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 353.966 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="359" owner="0" type="0" pos="11.0508 -14 58.565" rot="-1 0 0 1.5708" scale="" transform="1 0 0 11.0508 0 5.96046e-008 -1 -14 0 1 5.96046e-008 58.565 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.8774 1 -2" />
                            <Vertex pos="-1.5867 1.43505 -2" />
                            <Vertex pos="-1.5867 1.43505 2" />
                            <Vertex pos="-1.8774 1 2" />
                            <Vertex pos="-1.0508 1.12565 -2" />
                            <Vertex pos="-1.0508 1.12565 2" />
                            <Vertex pos="-1.0508 0.365739 2" />
                            <Vertex pos="-1.0508 0.365739 -2" />
                        </Vertices>
                        <Face id="12" plane="-0.831462 0.555582 0 -2.11657" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 -26.5166 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0.499998 0.866027 -0 -0.449446" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.866025 -0.5 0 194.933 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.5 -0.866025 0 14.3819 -0.831472 0.555566 0 59.9959 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1414.5 0 -1 0 -7496.31 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0.608754 -0.793359 -0 -0.349517" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.866025 -0.5 0 194.933 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="17" plane="1 -0 0 1.0508" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 439.684 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="361" owner="0" type="0" pos="10.5876 -14 57.9541" rot="-1 0 0 1.5708" scale="" transform="1 0 0 10.5876 0 5.96046e-008 -1 -14 0 1 5.96046e-008 57.9541 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.7592 1.21752 -2" />
                            <Vertex pos="-1.41422 1.6109 -2" />
                            <Vertex pos="-1.41422 1.6109 2" />
                            <Vertex pos="-1.7592 1.21752 2" />
                            <Vertex pos="-0.587622 0.0459456 2" />
                            <Vertex pos="-0.587622 0.0459456 -2" />
                            <Vertex pos="-0.587631 0.976641 2" />
                            <Vertex pos="-0.587631 0.976641 -2" />
                        </Vertices>
                        <Face id="12" plane="-0.751845 0.65934 0 -2.12541" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 161.286 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.707106 -0.707108 -0 -0.383022" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.793354 -0.608761 0 195.284 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="14" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.608761 -0.793354 0 13.347 -0.75184 0.659346 0 59.713 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1355.22 0 -1 0 -7418.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="16" plane="0.608758 0.793356 -0 -0.417098" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.793354 -0.608761 0 195.284 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="17" plane="1 9.67051e-006 -0 0.587622" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 517.879 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="367" owner="0" type="0" pos="-10.5876 -14 57.954" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -10.5876 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 57.954 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.6109 1.41421 -2" />
                            <Vertex pos="-1.21751 1.7592 -2" />
                            <Vertex pos="-1.21751 1.7592 2" />
                            <Vertex pos="-1.6109 1.41421 2" />
                            <Vertex pos="-0.0459426 0.58763 2" />
                            <Vertex pos="-0.976645 0.58763 2" />
                            <Vertex pos="-0.976645 0.58763 -2" />
                            <Vertex pos="-0.0459426 0.58763 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.659342 0.751843 0 -2.1254" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 350.712 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.707106 -0.707107 0 12.257 -0.659347 0.751839 0 59.7129 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1285.88 0 -1 0 -7348.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.707108 0.707106 -0 -0.38303" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.707107 -0.707106 0 195.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.793354 -0.60876 -0 -0.4171" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.707107 -0.707106 0 195.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 0.58763" album="" material="bm_grid_blank4" texgens="-1 0 0 12.257 0 0 1 59.7129 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="368" owner="0" type="0" pos="-11.0508 -14 58.5649" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -11.0508 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 58.5649 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.43505 1.5867 -2" />
                            <Vertex pos="-0.999996 1.8774 -2" />
                            <Vertex pos="-0.999996 1.8774 2" />
                            <Vertex pos="-1.43505 1.5867 2" />
                            <Vertex pos="-0.365736 1.05081 2" />
                            <Vertex pos="-1.12565 1.05081 2" />
                            <Vertex pos="-1.12565 1.05081 -2" />
                            <Vertex pos="-0.365736 1.05081 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.555579 0.831464 0 -2.11657" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 538.519 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.793354 -0.608761 0 11.1851 -0.555564 0.831474 0 59.9957 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1207.69 0 -1 0 -7289.5 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.793356 0.608758 -0 -0.349531" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.608761 -0.793354 0 195.142 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.866023 -0.500005 -0 -0.449429" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.608761 -0.793354 0 195.142 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.05081" album="" material="bm_grid_blank4" texgens="-1 0 0 11.1851 0 0 1 59.9957 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="369" owner="0" type="0" pos="-11.4276 -14 59.2346" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -11.4276 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 59.2346 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.23463 1.73206 -2" />
                            <Vertex pos="-0.765362 1.96347 -2" />
                            <Vertex pos="-0.765362 1.96347 2" />
                            <Vertex pos="-1.23463 1.73206 2" />
                            <Vertex pos="-0.455966 1.42758 2" />
                            <Vertex pos="-1.10851 1.42758 2" />
                            <Vertex pos="-1.10851 1.42758 -2" />
                            <Vertex pos="-0.455966 1.42758 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.442277 0.896878 0 -2.0995" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 569.147 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.866027 -0.499998 0 10.2049 -0.442287 0.896873 0 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1121.97 0 -1 0 -7241.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.866026 0.5 -0 -0.318911" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.499998 -0.866027 0 194.659 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.923879 -0.382684 -0 -0.477817" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.499998 -0.866027 0 194.659 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.42758" album="" material="bm_grid_blank4" texgens="-1 0 0 10.2049 0 0 1 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="370" owner="0" type="0" pos="-11.7115 -14 59.9516" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -11.7115 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 59.9516 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.0131 1.84775 -2" />
                            <Vertex pos="-0.517632 2.01595 -2" />
                            <Vertex pos="-0.517632 2.01595 2" />
                            <Vertex pos="-1.0131 1.84775 2" />
                            <Vertex pos="-0.391513 1.71147 2" />
                            <Vertex pos="-0.976578 1.71147 2" />
                            <Vertex pos="-0.976578 1.71147 -2" />
                            <Vertex pos="-0.391513 1.71147 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.321459 0.946924 0 -2.07535" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 379.723 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382681 0 9.38348 -0.321438 0.946931 0 61.3147 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1030.19 0 -1 0 -7204.93 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.92388 0.382682 -0 -0.293237" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.382681 -0.92388 0 193.939 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.965915 -0.258858 -0 -0.500263" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.382681 -0.92388 0 193.939 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.71147" album="" material="bm_grid_blank4" texgens="-1 0 0 9.38348 0 0 1 61.3147 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="371" owner="0" type="0" pos="-11.8976 -14 60.7036" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -11.8976 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 60.7036 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.77422 1.93185 -2" />
                            <Vertex pos="-0.261044 2.03393 -2" />
                            <Vertex pos="-0.261044 2.03393 2" />
                            <Vertex pos="-0.77422 1.93185 2" />
                            <Vertex pos="-0.224525 1.89763 2" />
                            <Vertex pos="-0.769715 1.89763 2" />
                            <Vertex pos="-0.769715 1.89763 -2" />
                            <Vertex pos="-0.224525 1.89763 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.195096 0.980784 0 -2.04578" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 188.182 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.965926 -0.258816 0 8.77642 -0.195087 0.980786 0 62.2611 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -933.928 0 -1 0 -7181.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.96593 0.258802 -0 -0.274236" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.258816 -0.965927 0 193.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.991446 -0.130521 -0 -0.515449" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.258816 -0.965927 0 193.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="0 -1 0 1.89763" album="" material="bm_grid_blank4" texgens="-1 0 0 8.77642 0 0 1 62.2611 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="372" owner="0" type="0" pos="-11.9829 -14 61.4779" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -11.9829 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 61.4779 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.522091 1.98289 -2" />
                            <Vertex pos="1.14441e-005 2.01711 -2" />
                            <Vertex pos="1.14441e-005 2.01711 2" />
                            <Vertex pos="-0.522091 1.98289 2" />
                            <Vertex pos="0.00451622 1.98289 2" />
                            <Vertex pos="0.00451621 1.98289 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.0654026 0.997859 0 -2.01279" album="" material="bm_tile09_A" texgens="0.965927 0.258815 0 -2.20068 0 0 1 512 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.991446 -0.130523 0 8.42526 -0.0654021 0.997859 0 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -834.826 0 -1 0 -7170.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="9" plane="0.991446 0.130515 -2.53923e-009 -0.263274" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.130523 -0.991445 0 191.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 5 4 2" />
                        </Face>
                        <Face id="10" plane="0 -1 0 1.98289" album="" material="bm_grid_blank4" texgens="-1 0 0 8.42526 0 0 1 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="373" owner="0" type="0" pos="-6.52211 -14 56.0171" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -6.52211 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 56.0171 0 0 0 1" group="-1" locked="0" nextFaceID="12" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.01711 -2.98023e-007 -2" />
                            <Vertex pos="-1.98289 0.522105 -2" />
                            <Vertex pos="-1.98289 0.522105 2" />
                            <Vertex pos="-2.01711 -2.98023e-007 2" />
                            <Vertex pos="-1.9829 -0.00450465 2" />
                            <Vertex pos="-1.9829 -0.00450466 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.997859 0.0654022 0 -2.01279" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 -2.2002 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 16.7073 -0.997859 0.065402 0 63.3165 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1533.81 0 -1 0 -7869.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="9" plane="-0.130541 -0.991443 -0 -0.263315" album="" material="bm_grid_blank4" texgens="0 0 -1 64 1 0 0 191.453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="10" plane="1 -1.90152e-005 4.87005e-014 1.9829" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 66.8291 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="374" owner="0" type="0" pos="-7.29633 -14 56.1023" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -7.29633 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 56.1023 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.03393 0.261053 -2" />
                            <Vertex pos="-1.93185 0.774222 -2" />
                            <Vertex pos="-1.93185 0.774222 2" />
                            <Vertex pos="-2.03393 0.261053 2" />
                            <Vertex pos="-1.89763 0.769717 2" />
                            <Vertex pos="-1.89763 0.224533 2" />
                            <Vertex pos="-1.89763 0.224533 -2" />
                            <Vertex pos="-1.89763 0.769717 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.980784 0.195098 0 -2.04578" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 188.181 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.130526 -0.991445 0 16.4941 -0.980786 0.195089 0 62.2612 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1522.9 0 -1 0 -7770.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.130523 0.991445 -0 -0.515448" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.991445 -0.130526 0 192.524 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.258809 -0.965928 -0 -0.274241" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.991445 -0.130526 0 192.524 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.89763" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 165.93 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="375" owner="0" type="0" pos="-8.04837 -14 56.2885" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -8.04837 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 56.2885 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.01594 0.517635 -2" />
                            <Vertex pos="-1.84776 1.0131 -2" />
                            <Vertex pos="-1.84776 1.0131 2" />
                            <Vertex pos="-2.01594 0.517635 2" />
                            <Vertex pos="-1.71147 0.976581 2" />
                            <Vertex pos="-1.71147 0.391519 2" />
                            <Vertex pos="-1.71147 0.391519 -2" />
                            <Vertex pos="-1.71147 0.976581 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.946935 0.321426 0 -2.07534" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 379.724 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.258819 -0.965926 0 16.011 -0.946931 0.321438 0 61.3146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1499.07 0 -1 0 -7673.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.258821 0.965925 -0 -0.50034" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.965926 -0.258819 0 193.505 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.382684 -0.923879 -0 -0.293237" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.965926 -0.258819 0 193.505 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.71147" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 262.191 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="376" owner="0" type="0" pos="-8.76537 -14 56.5724" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -8.76537 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 56.5724 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.96347 0.765367 -2" />
                            <Vertex pos="-1.73206 1.23463 -2" />
                            <Vertex pos="-1.73206 1.23463 2" />
                            <Vertex pos="-1.96347 0.765367 2" />
                            <Vertex pos="-1.42757 1.10851 2" />
                            <Vertex pos="-1.42757 0.455967 2" />
                            <Vertex pos="-1.42757 0.455967 -2" />
                            <Vertex pos="-1.42757 1.10851 -2" />
                        </Vertices>
                        <Face id="6" plane="-0.896876 0.442281 0 -2.0995" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.258819 -0.965926 0 569.146 0 0.125 0.129409" texRot="0" texScale="0.125 0.129409" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.382684 -0.92388 0 15.2904 -0.89687 0.442295 0 60.542 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="8" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1462.73 0 -1 0 -7582.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="9" plane="0.382673 0.923884 -0 -0.477841" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.923879 -0.382683 0 194.326 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="10" plane="-0.499998 -0.866027 -0 -0.318902" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.923879 -0.382683 0 194.326 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="11" plane="1 0 0 1.42757" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 353.966 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="377" owner="0" type="0" pos="-9.43505 -14 56.9491" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -9.43505 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 56.9491 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.8774 1 -2" />
                            <Vertex pos="-1.5867 1.43505 -2" />
                            <Vertex pos="-1.5867 1.43505 2" />
                            <Vertex pos="-1.8774 1 2" />
                            <Vertex pos="-1.0508 1.12565 -2" />
                            <Vertex pos="-1.0508 1.12565 2" />
                            <Vertex pos="-1.0508 0.365739 2" />
                            <Vertex pos="-1.0508 0.365739 -2" />
                        </Vertices>
                        <Face id="12" plane="-0.831462 0.555582 0 -2.11657" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 -26.5166 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="0.499998 0.866027 -0 -0.449446" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.866025 -0.5 0 194.933 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="14" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.5 -0.866025 0 14.3819 -0.831472 0.555566 0 59.9959 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1414.5 0 -1 0 -7496.31 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="16" plane="-0.608754 -0.793359 -0 -0.349517" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.866025 -0.5 0 194.933 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="17" plane="1 -0 0 1.0508" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 439.684 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="378" owner="0" type="0" pos="-10.0459 -14 57.4123" rot="-0.57735 -0.57735 0.57735 2.0944" scale="" transform="5.96046e-008 1 5.96046e-008 -10.0459 0 5.96046e-008 -1 -14 -1 5.96046e-008 3.55271e-015 57.4123 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.7592 1.21752 -2" />
                            <Vertex pos="-1.41422 1.6109 -2" />
                            <Vertex pos="-1.41422 1.6109 2" />
                            <Vertex pos="-1.7592 1.21752 2" />
                            <Vertex pos="-0.587622 0.0459456 2" />
                            <Vertex pos="-0.587622 0.0459456 -2" />
                            <Vertex pos="-0.587631 0.976641 2" />
                            <Vertex pos="-0.587631 0.976641 -2" />
                        </Vertices>
                        <Face id="12" plane="-0.751845 0.65934 0 -2.12541" album="" material="bm_tile09_A" texgens="0 0 1 0 -0.707106 -0.707108 0 161.286 0 0.125 0.12941" texRot="0" texScale="0.125 0.12941" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="13" plane="-0.707106 -0.707108 -0 -0.383022" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.793354 -0.608761 0 195.284 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="14" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="-0.608761 -0.793354 0 13.347 -0.75184 0.659346 0 59.713 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="15" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1355.22 0 -1 0 -7418.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="16" plane="0.608758 0.793356 -0 -0.417098" album="" material="bm_grid_blank4" texgens="0 0 -1 64 0.793354 -0.608761 0 195.284 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="17" plane="1 9.67051e-006 -0 0.587622" album="" material="bm_grid_blank4" texgens="0 0 -1 0 0 -1 0 517.879 0 0.25 0.250001" texRot="0" texScale="0.25 0.250001" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="379" owner="0" type="0" pos="6 -14 59" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -14 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 5" />
                            <Vertex pos="6 2 -11" />
                            <Vertex pos="6 -2 5" />
                            <Vertex pos="6 -2 -11" />
                            <Vertex pos="4 2 5" />
                            <Vertex pos="4 2 -11" />
                            <Vertex pos="4 -2 5" />
                            <Vertex pos="4 -2 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="380" owner="0" type="0" pos="6 -14 65" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -14 0 0 1 65 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="3.5 2 1" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="3.5 -2 1" />
                            <Vertex pos="4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 -0 -0.242536 3.63803" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="6 -14 67" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -14 0 0 1 67 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 3" />
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 -2 3" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="4 2 3" />
                            <Vertex pos="3.5 2 -1" />
                            <Vertex pos="4 -2 3" />
                            <Vertex pos="3.5 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.992278 0 0.124035 3.59701" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="-16 -14 65" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 65 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 2 1" />
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6.5 -2 1" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="4 2 1" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="0.970143 0 -0.242536 -6.06339" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="-16 -14 67" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 67 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 3" />
                            <Vertex pos="6.5 2 -1" />
                            <Vertex pos="6 -2 3" />
                            <Vertex pos="6.5 -2 -1" />
                            <Vertex pos="4 2 3" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="4 -2 3" />
                            <Vertex pos="4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="0.992278 -0 0.124035 -6.32577" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="-16 -14 59" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 5" />
                            <Vertex pos="6 2 -11" />
                            <Vertex pos="6 -2 5" />
                            <Vertex pos="6 -2 -11" />
                            <Vertex pos="4 2 5" />
                            <Vertex pos="4 2 -11" />
                            <Vertex pos="4 -2 5" />
                            <Vertex pos="4 -2 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="-16 -14 81" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 81 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -11" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="6 -2 -11" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="4 2 -11" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="4 -2 -11" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="386" owner="0" type="0" pos="8 -18 59" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -18 0 0 1 59 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 13" />
                            <Vertex pos="6 2 -12.5" />
                            <Vertex pos="6 -6 14" />
                            <Vertex pos="6 -6 -12.5" />
                            <Vertex pos="4 2 13" />
                            <Vertex pos="4 2 -12.5" />
                            <Vertex pos="4 -6 14" />
                            <Vertex pos="4 -6 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.124035 0.992278 -13.1477" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="387" owner="0" type="0" pos="16 -14 71" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -14 0 0 1 71 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 2 1" />
                            <Vertex pos="-4 2 -1" />
                            <Vertex pos="-4 -2 1" />
                            <Vertex pos="-4 -2 -1" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 2 -1" />
                            <Vertex pos="-6 -2 1" />
                            <Vertex pos="-6 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 4" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="18 -14 71" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 -14 0 0 1 71 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 2 -24.5" />
                            <Vertex pos="-4 -2 1" />
                            <Vertex pos="-4 -2 -24.5" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 2 -24.5" />
                            <Vertex pos="-6 -2 1" />
                            <Vertex pos="-6 -2 -24.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 4.47214" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="389" owner="0" type="0" pos="-2 -84 23" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -84 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 19" />
                            <Vertex pos="6 2 -33" />
                            <Vertex pos="6 -2 19" />
                            <Vertex pos="6 -2 -33" />
                            <Vertex pos="-2 2 21" />
                            <Vertex pos="-2 2 -33" />
                            <Vertex pos="-2 -2 21" />
                            <Vertex pos="-2 -2 -33" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -19.8879" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="390" owner="0" type="0" pos="-2 -88 23" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -88 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 21" />
                            <Vertex pos="2 2 -33" />
                            <Vertex pos="0 -2 22" />
                            <Vertex pos="0 -2 -33" />
                            <Vertex pos="-2 2 21" />
                            <Vertex pos="-2 2 -33" />
                            <Vertex pos="-2 -2 22" />
                            <Vertex pos="-2 -2 -33" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -0.894427" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -20.8581" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="391" owner="0" type="0" pos="11 12 0.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 12 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 3.75" />
                            <Vertex pos="1 2 -8.25" />
                            <Vertex pos="1 -6.5 3.75" />
                            <Vertex pos="1 -6.5 -8.25" />
                            <Vertex pos="-7 2 3.75" />
                            <Vertex pos="-7 2 -8.25" />
                            <Vertex pos="-5 -5.5 3.75" />
                            <Vertex pos="-5 -5.5 -8.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.966235 -0.257663 0 -6.24832" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.164399 -0.986394 -0 -6.24716" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_tile10_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="392" owner="0" type="0" pos="4 14 6.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 14 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2 0 16.75" />
                            <Vertex pos="2 0 -16.75" />
                            <Vertex pos="-2 2 16.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-2 0 16.75" />
                            <Vertex pos="-2 0 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 -1632 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.75" album="" material="bm_tile10_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="393" owner="0" type="0" pos="6 -84 23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -84 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -33" />
                            <Vertex pos="1 -2 19" />
                            <Vertex pos="1 -2 -33" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -33" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -33" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -1.45521" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -16.0997" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="394" owner="0" type="0" pos="2 -80 23" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -80 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 17" />
                            <Vertex pos="4 2 -33" />
                            <Vertex pos="6 -2 17" />
                            <Vertex pos="6 -2 -33" />
                            <Vertex pos="0 3 17" />
                            <Vertex pos="0 3 -33" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -33" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -4.47214" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.928477 0.371391 0 -1.11417" album="" material="bm_grid_blank4" texgens="0 -1 0 2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.242536 0.970142 -0 -2.91043" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -17" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="12 12 0.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 12 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 5.75" />
                            <Vertex pos="2 2 -8.25" />
                            <Vertex pos="2 -2 5.75" />
                            <Vertex pos="2 -2 -8.25" />
                            <Vertex pos="-2 2 5.75" />
                            <Vertex pos="-2 2 -8.25" />
                            <Vertex pos="0 -2 5.75" />
                            <Vertex pos="-9.53674e-007 -2 -8.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -2048 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447213 0 -0.894428" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 0 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.75" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.25" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="15 -72 18" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -72 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 -4" />
                            <Vertex pos="1 16 -28" />
                            <Vertex pos="1 -4 -4" />
                            <Vertex pos="1 -4 -28" />
                            <Vertex pos="-1 16 -4" />
                            <Vertex pos="-1 16 -28" />
                            <Vertex pos="-1 -4 -4" />
                            <Vertex pos="-1 -4 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="-9 -68 18" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -68 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 -4" />
                            <Vertex pos="1 16 -28" />
                            <Vertex pos="1 -18 -4" />
                            <Vertex pos="1 -18 -28" />
                            <Vertex pos="-1 16 -4" />
                            <Vertex pos="-1 16 -28" />
                            <Vertex pos="-1 -18 -4" />
                            <Vertex pos="-1 -18 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -18" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="11 -94 18" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -94 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 16 -4" />
                            <Vertex pos="2 16 -28" />
                            <Vertex pos="2 14 -4" />
                            <Vertex pos="2 14 -28" />
                            <Vertex pos="-6 16 -4" />
                            <Vertex pos="-6 16 -28" />
                            <Vertex pos="-6 14 -4" />
                            <Vertex pos="-6 14 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 14" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 4" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="0" type="0" pos="13 -68 18" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -68 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 -20" />
                            <Vertex pos="1 16 -28" />
                            <Vertex pos="1 -10 -20" />
                            <Vertex pos="1 -10 -28" />
                            <Vertex pos="-9 16 -20" />
                            <Vertex pos="-9 16 -28" />
                            <Vertex pos="-9 -10 -20" />
                            <Vertex pos="-9 -10 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 20" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="0" type="0" pos="1 -72 18" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -72 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5 20 -20" />
                            <Vertex pos="-5 20 -28" />
                            <Vertex pos="-5 -10 -20" />
                            <Vertex pos="-5 -10 -28" />
                            <Vertex pos="-9 20 -20" />
                            <Vertex pos="-9 20 -28" />
                            <Vertex pos="-9 -10 -20" />
                            <Vertex pos="-9 -10 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 5" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 20" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="5 -72 18" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -72 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 24 -20" />
                            <Vertex pos="-1 24 -28" />
                            <Vertex pos="-1 -10 -20" />
                            <Vertex pos="-1 -10 -28" />
                            <Vertex pos="-9 24 -20" />
                            <Vertex pos="-9 24 -28" />
                            <Vertex pos="-9 -10 -20" />
                            <Vertex pos="-9 -10 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 20" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="-12 0 54" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 0 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0 -22" />
                            <Vertex pos="0 0 -28" />
                            <Vertex pos="0 -2 -22" />
                            <Vertex pos="0 -2 -28" />
                            <Vertex pos="-2 0 -22" />
                            <Vertex pos="-2 0 -28" />
                            <Vertex pos="-2 -2 -22" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 22" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="-12 18 54" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 18 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -22" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 -22" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 1 -22" />
                            <Vertex pos="-2 1 -28" />
                            <Vertex pos="-2 -2 -22" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 -1.45521" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 22" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="-8 18 54" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 18 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -24" />
                            <Vertex pos="2 4 -28" />
                            <Vertex pos="1 -2 -22" />
                            <Vertex pos="1 -2 -28" />
                            <Vertex pos="-2 4 -24" />
                            <Vertex pos="-2 4 -28" />
                            <Vertex pos="-2 -2 -22" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="0.986394 -0.164399 0 -1.31519" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 21.5035" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="-4 18 54" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 18 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -24" />
                            <Vertex pos="2 4 -28" />
                            <Vertex pos="2 -2 -24" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 4 -24" />
                            <Vertex pos="-2 4 -28" />
                            <Vertex pos="-3 -2 -24" />
                            <Vertex pos="-3 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_friction_sand" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 0.164399 0 -2.63038" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 24" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="-12 14 54" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 14 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -22" />
                            <Vertex pos="2 2 -24" />
                            <Vertex pos="2 0 -22" />
                            <Vertex pos="2 0 -24" />
                            <Vertex pos="-2 2 -22" />
                            <Vertex pos="-2 2 -24" />
                            <Vertex pos="-2 0 -22" />
                            <Vertex pos="-2 0 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 22" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="0" type="0" pos="-6 12 54" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 12 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -18" />
                            <Vertex pos="2 2 -46" />
                            <Vertex pos="2 -2 -18" />
                            <Vertex pos="2 -2 -46" />
                            <Vertex pos="-4 2 -18" />
                            <Vertex pos="-4 2 -46" />
                            <Vertex pos="-4 -2 -18" />
                            <Vertex pos="-4 -2 -46" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 18" album="" material="bm_tile10_A" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -46" album="" material="bm_grid_blank4" texgens="-1 0 0 2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="0" type="0" pos="-29 15 37" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 15 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15 1 7" />
                            <Vertex pos="15 1 -7" />
                            <Vertex pos="15 -1 7" />
                            <Vertex pos="15 -1 -7" />
                            <Vertex pos="13 1 7" />
                            <Vertex pos="13 1 -7" />
                            <Vertex pos="13 -1 7" />
                            <Vertex pos="13 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -15" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 13" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="0" type="0" pos="-25 15 43" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 15 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15 1 1" />
                            <Vertex pos="15 1 -7" />
                            <Vertex pos="15 -1 1" />
                            <Vertex pos="15 -1 -7" />
                            <Vertex pos="11 1 1" />
                            <Vertex pos="11 1 -7" />
                            <Vertex pos="11 -1 1" />
                            <Vertex pos="11 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -15" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 11" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2944 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 3200 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="0" type="0" pos="-9 -98 42" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -98 0 0 1 42 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 -8" />
                            <Vertex pos="1 16 -28" />
                            <Vertex pos="1 12 -8" />
                            <Vertex pos="1 12 -28" />
                            <Vertex pos="-1 16 -12" />
                            <Vertex pos="-1 16 -28" />
                            <Vertex pos="-1 12 -12" />
                            <Vertex pos="-1 12 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 12" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.894427 0 0.447214 4.47214" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 2048 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="0" type="0" pos="0 -17 55" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -17 0 0 1 55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 1" />
                            <Vertex pos="4 3 -11" />
                            <Vertex pos="4 -1 1" />
                            <Vertex pos="4 1 -11" />
                            <Vertex pos="-4 1 1" />
                            <Vertex pos="-4 3 -11" />
                            <Vertex pos="-4 -1 1" />
                            <Vertex pos="-4 1 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.986394 0.164399 -1.15079" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.986394 -0.164399 -0.821995" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="0 -31 53.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -31 0 0 1 53.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -0.5 -1.5" />
                            <Vertex pos="-4 1 -1.5" />
                            <Vertex pos="-4 1 0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="0 1 -3.5" />
                            <Vertex pos="0 1 0.5" />
                            <Vertex pos="0 -0.75 0.5" />
                            <Vertex pos="0 -0.75 -3.5" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="-0.0623783 -0.998053 -0 -0.748539" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="-0.447214 0 -0.894427 -3.1305" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="0 -31 53.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -31 0 0 1 53.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -1 -1.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 1 0.5" />
                            <Vertex pos="4 1 -1.5" />
                            <Vertex pos="0 1 -3.5" />
                            <Vertex pos="0 1 0.5" />
                            <Vertex pos="0 -0.75 0.5" />
                            <Vertex pos="0 -0.75 -3.5" />
                        </Vertices>
                        <Face id="6" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0.0623783 -0.998053 -0 -0.748539" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0.5" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0.447214 0 -0.894427 -3.1305" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="417" owner="0" type="0" pos="0 -29 54" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -29 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -1 -2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 1 0" />
                            <Vertex pos="-4 -1 0" />
                            <Vertex pos="0 1 -4" />
                            <Vertex pos="0 1 0" />
                            <Vertex pos="0 -1 0" />
                            <Vertex pos="0 -1 -4" />
                        </Vertices>
                        <Face id="6" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="-0.447214 0 -0.894427 -3.57771" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="418" owner="0" type="0" pos="0 -29 54" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -29 0 0 1 54 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="4 -1 0" />
                            <Vertex pos="4 1 0" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="0 1 -4" />
                            <Vertex pos="0 1 0" />
                            <Vertex pos="0 -1 0" />
                            <Vertex pos="0 -1 -4" />
                        </Vertices>
                        <Face id="6" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1920 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0 -1 -0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0.447214 0 -0.894427 -3.57771" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 -0" album="" material="bm_grid_blank4" texgens="0 -1 0 2304 0 0 1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
