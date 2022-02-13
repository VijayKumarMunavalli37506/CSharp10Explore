import os
import cv2
import numpy as np
import matplotlib.pyplot as plt


def load_images_from_folder(foldername):
    images = []
    for filename in os.listdir(foldername):
        img = cv2.imread(os.path.join(foldername,filename))
        if img is not None:
            images.append(img)
    return images

img_list=load_images_from_folder("Untitled Folder")


# OpenCV opens images as BRG 
# but we want it as RGB We'll 
# also need a grayscale version
# Converting image to grayscale
gray_img = cv2.cvtColor(img_list[5], cv2.COLOR_BGR2RGB)
  
  
# Use minSize because for not 
# Loading the required haar-cascade xml classifier file
haar_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'Haarcascade_frontalface_default.xml')
  
# Applying the face detection method on the grayscale image
faces_rect = haar_cascade.detectMultiScale(gray_img, 1.1, 9)
  
# Don't do anything if there's 
# no sign
amount_found = len(faces_rect)
  
if amount_found != 0:
      
    # There may be more than one
    # sign in the image
    for (x, y, width, height) in faces_rect:
          
        # We draw a green rectangle around
        # every recognized sign
        cv2.rectangle(gray_img, (x, y), 
                      (x + height, y + width), 
                      (255, 0, 0), 5)
          
# Creates the environment of 
# the picture and shows it
plt.subplot(1, 1, 1)
plt.imshow(gray_img)
plt.show()
  
  
