   M S B A M L   `   `   `  ����F  BWpfAndMVVM1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfAndMVVM1WpfAndMVVM1  5   	       WpfAndMVVM1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfAndMVVM1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ label1��5
      $
��Left=�6Q   $��
105,86,0,0q�6l   $	��Top=�6�   ��6    ��  �� Path$
 Text� �� ElementName$ tbox1��6�   �� 5   
   -   5         ��Name$ tbox1��5      $
��Left=�6!   $��26��6<   $��
188,86,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $
��bobr��6p   $	��Top=�6|   $	��212��6�   �� 5   
   -   5        $ tbox2��5      $
��Left=�6!   $��130,156,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6�   $	��120��6�   ��6e   �� $
 Text�$ tbox3�� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=�6�   �� 5   
   -   5        $ tbox3��5      $
��Left=�6!   $��312,156,0,0q�6<   $
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��120��6�   �� 5   
   -   5         ��Name$ slider1��5      $
��Left=�6"   $��	130,0,0,0q�6=   $��Center=�6P   $	��120��6k   	 � Maximum$		 100Q�6w   �� 5   
   -   5        $ 
tboxSlider��5      $
��Left=�6&   $��	312,0,0,0q�6A   $
 Wrap=�6T   $��Center=�6�   $	��120��6�   ��6h   �� $ slider1��$ Value�$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $ slider2��5      $
��Left=�6"   $��130,258,0,0q�6=   $	��Top=�6R   $	��120��6j   $		 100Q�6v   �� 5   
   -   5        $ tboxSlider2��5      $
��Left=�6'   $��312,249,0,0q�6B   $
 Wrap=�6W   $��0��6k   $	��Top=�6t   $	��120��6�   �� 5   
   -	   5        $ label2��5      $
��Left=�6R   $��173,313,0,0q�6m   $	��Top=�6�   ��6    �� $ MyLabelText�$ OneWay=�6�   �� 5   
   -
   5        
 ��Name$
 updateLabelButton��5      $��Update Label��6,   $
��Left=�6C   $��385,308,0,0q�6^   $	��Top=�6s   6�   �� 5   
   -   5        $ 
tboxUpdate��5      $
��Left=�6&   $��123,371,0,0q�6A   $
 Wrap=�6V   $	��Top=�6�   $	��120��6�   ��6j   �� $ MyTextBoxText�$ OneWay=�6�   �� 5   
   -   5        $
 UpdateTBoxButton��5      $��Update TextBox��6+   $
��Left=�6D   $��385,369,0,0q�6_   $	��Top=�6t   6�   5      5      