   M S B A M L   `   `   `  ����  MaheshwariApp_Inventory#    MaheshwariApp_Inventory.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��458��6   $	��718��6$    � WindowState$ Normal=�60   ��5      �� 5   
    �� ImageSource$  /Images/background_WPF.jpg��6   6@   .��5	      � .+�5
   
   A� ���	#FFF4F4F5$��Center=�6#   $	��334��6@   
���   �$��Center=�6\   $	��583��6w   �� 5   
   $
��Left=�6   $��33��6-   $��306,107,0,0q�69    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6N   �� *
UserName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��29��6-   $��306,160,0,0q�69   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6N   �� *
Password+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $��
User Name:��6   $
��Left=�6%   $��226,114,0,0q�6@   $	��Top=�6U   $��92��6m   �� 5   
   $��	Password:��6   $
��Left=�6$   $��228,163,0,0q�6?   $	��Top=�6T   $��92��6l   �� 5   
   $��3��6   $��2��6   y�61   �� *isAuthenticated+   	BoolToVis �� 	Converter# [  .��6~   User has been authenticated5      �� 5   
   $��Authenticate��6   $
��Left=�6I   $��252,231,0,0q�6d   $	��Top=�6y   $	��114��6�   $��34��6�   ��6(   �� *LoginCommand+6�   5      5      