   M S B A M L   `   `   `  ����@  <Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FinalFinal  5   	       Final.Userlogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:Final  5   	     � Title$  	Userlogin��5	   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�6G   
�������.��5
      ]� .+�5   
   � -   5        $	��Top=�5      $��30��6$   
���� ��.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Center=�6N   $
��20,0q�6i   .+�5      �� -   5         *  &MaterialDesignFloatingActionMiniButton#��[  5      $��20��6Z   $��20��6f   ��6r   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6.   5      �� 5      -   5        #��[  5      $��20��6Y   $��20��6e   ��6q   Z� ��6�   Z� .��5        $ Power=�6.   5      5      5      � 5   
   .+�5      � $��71,73,315,298.2q�6   .+�5      �� -   5         ��Name$	 cb1��5      $
��Left=�6(   $	��Top=�6C   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 请选择充值时长��5      $��72��5      $��68,0,0,0q�5       & "MaterialDesignFloatingHintComboBox#��[ 5      $��48��6Q   $	��180��6]   $��16(�6i   $��Forte)�6w   $
��Bold"�6�   ��5      �� *#!LongListToTestComboVirtualization+.@�5      �� $��1��6#   �� 5      $��3��6#   �� 5      $��6��6#   �� 5       $��12��6#   5"      �� 5#      -   5        $��确定��5#      $
��Left=�6&   $��
340,16,0,0q�6A   $	��Top=�6U   $��74��6m   $��16(�6x   6�   �� 5$      $��	充值：��6   $
��Left=�6&   $��0,16,0,0q�6A   $	��Top=�6S   $��18(�6k   $��29��6y   $��68��6�   $��Forte)�6�   $
��Bold"�6�   �� 5%      $��个月��6   $
��Left=�6%   $��
253,16,0,0q�6@   $	��Top=�6T   $��32��6l   $��56��6x   $��18(�6�   $��Forte)�6�   $
��Bold"�6�   5'      �� 5(      -   5        $	��lb1��5(      $
��Left=�6    $��
433,10,0,0q�6;   $	��Top=�6O   $	��357��6g   $��16(�6s   $��Forte)�6�   $��36��6�   �� 5)      -   5        $	��lb2��5)      $
��Left=�6    $��249,235,0,0q�6;   $	��Top=�6P   $y�Hidden=�6h   Z� 5*      -   5        $��docView��5*      $
��Left=�6,   $��307,192,0,-25.8q�6G   $	��Top=�6`   
�������6x   �� 5+      -	   5          MaterialDesignRaisedButton#��[ 5+      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�5,         IsIndicatorVisible . 	   IsIndeterminate	 . $��读取Word文件��5/      $
��Left=�6   $��
67,235,0,0q�64   $	��Top=�6H   $	��164��6`   $��45��6l   $��18(�6x   $��Forte)�6�   $��Normal"�6�   6�   �� 50      -
   5         + 'MaterialDesignFloatingActionLightButton#��[ 51      $��54,323,690,40.2q�52      ��53      �� *SaveCommand+ 54      �� *
IsSaving+ 55      �� *SaveProgress+.��57        $��24��58   	   $��24��59   	   ��5:      �� 5;      
 �� 
TargetType"
  5<       �� BasedOn# [B 5=      .�5>      ��  �� Property �@ Kind �� Value$ 	CloudSync=�5@       �� Triggers 5A      �� 5B   "    �� Binding 5C      �� *IsSaveComplete+ �� Value True5D      .a�5E   &   ��  �@ Kind$ Check=�5G       N� EnterActions 5H   &   �� 5I   *   .��5J   .   �� .��5K   2   W�  �� TargetProperty$ Opacity�5L       W� From$ 0X�5M      	 W� To$ 1X�5N       g� Duration$ 0:0:0.8D�5O      5P   /   5Q   +   5S   #   5U      5W      5X      �� 5Y      $
��Left=�6   $��128,323,0,0q�64   $
��Wrap=�6I   $��将Word文件保存为Pdf��6]   $	��Top=�6r   $��56��6�   $	��129��6�   $��18(�6�   ���	#FF44295D$��Forte)�6�   $
��Bold"�6�   ��6�   Z� � 5[       � IsIndeterminate . $��0,159,0,256.2q�5\        5]      $ Bitcoin=�6&   $��34��65   $��37��6A   $��	39,85,0,0q�6L    J� RenderTransformOrigin$ 0.553,1.146&�6_   5^      5`      5a      