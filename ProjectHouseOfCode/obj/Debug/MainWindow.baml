   M S B A M L   `   `   `  ����M  IProjectHouseOfCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjectHouseOfCodeProjectHouseOfCode  5   	   #    ProjectHouseOfCode.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjectHouseOfCode     5   	     � Title$  PhotosFlickers��5      $	��600��61   $
��1070��6>   .��5      � -   5         �Name$ FlickrsPhotos��5      
������  � ColumnDefinitions 5	   
   �� 5
      $
��750* �6   �� 5      $	��31* �6   .+�5   
   �� 
�������$��2��6-   .+�5      � $��40��6   .+�5      �� $��Right=�6   $
��40 0q�69   .+�5      �� -   5         ��Name$ btnLogin��5      $��Login��6/   
������
���   �$��35��6k   $��93��6w   6�   5      5      5      �� 5   
   -   5        $��TabMenu��5   )   $��
20,65,2,20q�6    �� TabStripPlacement$
 Left=�68   $��2��6Q   .@�5      �� $	��150��6   $��30��6"   ��5      �� 5       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5      �� $&�� /Resources/PublicPictures-32.png��6    �� 5      $��Public Photos��6$   
����  �$��Center=�6K   $��5q�6f   5      .��5      �� .+�5      � -   5        $ ContentPublic��5      $	��482��62   .+�5       �� -   5        $��txtPublicPhotos��5    $   $��View Public Photos��6;   $��18(�6U    �� TextAlignment$ Center=�6c   $��5,14,-5,443q�6z   $��25��6�   �� 5!      -   5        $ btnSeePublicPhotos��5!   !   $��See Public Photos��6=   
����ح�
���   �$��35��6�   $	��110��6�   $��Center=�6�   $��655,9,12,438q�6�   �� 5"      -   5        $��FlickrImage��5"       $��UniformToFill=�63   $��4,52,8,5q�6K   $y�Visible=�6]   5#      5$      5'      �� 5)      $��30��6   ��5*      �� 5+      $ 
Horizontal=�6!   $��Center=�6:   .+�5,      �� $!��/Resources/Pictures_32a.png��6    �� 5-      $��View My Photos��6$   
����  �$��Center=�6L   $��5q�6g   5.      .��50      �� .+�51      � -   5        $ ContentMyPhotos��51      $	��482��64   .+�52      �� -	   5        $��txtMyPhotos��52   $   $��View My Photos��67   $��18(�6M   $ Center=�6[   $��5,14,-5,443q�6r   $��25��6�   �� 53      -
   5        $ btnSeeMyPhotos��53   !   $��See Private Photos��69   
����ح�
���   �$��35��6�   $	��110��6�   $��Center=�6�   $��655,9,12,438q�6�   54      55      56      �� 59      $��30��6   ��5:      �� 5;      $ 
Horizontal=�6!   $��Center=�6:   .+�5<      �� $ ��/Resources/City-Map-32.png��6    �� 5=      $��Photos on Map��6$   
����  �$��Center=�6K   $��5q�6f   5>      .��5@      �� .+�5A      � -   5        $ ContentPhotosMap��5A      $	��482��65   .+�5B      �� -   5        $��txtPhotosMap��5B   $   $��View Photos on Map��68   $��18(�6R   $ Center=�6`   $��5,14,-5,443q�6w   $��25��6�   �� 5C      -   5        $ btnSeePhotosMap��5C   !   $��See Photos on Map��6:   
����ح�
���   �$��35��6�   $	��110��6�   $��Center=�6�   $��655,9,12,438q�6�   5D      5E      5F      �� 5H      $��30��6   ��5I      �� 5J      $ 
Horizontal=�6!   $��Center=�6:   .+�5K      �� $��/Resources/user-32.png��6    �� 5L      $��My Profiles��6$   
����  �$��Center=�6I   $��5q�6d   5M      .��5O      �� .+�5P      � -   5        $ ContentMyProfile��5P      $	��482��65   .+�5Q      �� -   5        $��txtMyProfile��5Q   $   $��
My Profile��68   $��18(�6J   $ Center=�6X   $��5,14,-5,443q�6o   $��25��6�   �� 5R      -   5        $ btnSeeMyProfile��5R   !   $��See Profile��6:   
����ح�
���   �$��35��6{   $	��110��6�   $��Center=�6�   $��655,9,12,438q�6�   5S      5T      5U      5W      5X      5Y      