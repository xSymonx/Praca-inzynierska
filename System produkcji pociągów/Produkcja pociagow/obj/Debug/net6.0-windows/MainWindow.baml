   M S B A M L   `   `   `  ����M  IProdukcja Pociagow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Produkcja_PociagowProdukcja_Pociagow  5   	   #    Produkcja_Pociagow.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Produkcja_Pociagow     5   	     � Title$3  -System Planowania Produkcji Taboru Kolejowego��5   	   $
��1350��6T   
������� � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 =    &	 ^    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ #1a8aff��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ #002042��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   $
 15,15,15,15��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      � .+�5C   
   �� -   5         ��Name$ 
stackPanel��5C       �� Orientation$ Vertical=�6)   $
��Left=�6@   $��275                     ��6[   .+�5E      �� -   5         ��Name$ 
PokazCzynn��5E   =   #��� 
 6   $!��Pokaż wszystkie czynności��6Q   
�������$��18(�6�   $��70��6�   $��10,10,10,10q�6�   ���#005ab86�   �� 5F      -   5        #��� 
 5F      $%��Podział produkcji na kategorie��6=   
�������$��10,10,10,10q�6y   $��70��6�   $��18(�6�   ���#005ab86�   �� 5G      -   5        #��� 
 5G      $��Oblicz czas produkcji��6=   
�������$��10,10,10,10q�6p   $��70��6�   $��18(�6�   ���#005ab86�   5H       � 5I   
   -   5          �Name$
 Main��5I      $��285,10,10,10q�6    
�������  � NavigationUIVisibility$ Hidden=�6I   5J      5K      