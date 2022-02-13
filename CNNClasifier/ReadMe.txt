##Understanding of Convolution Neural Network

Convolutional Neural Nets (ConvNets or CNN) are a class of neural network specialized for image processing.

Like other neural networks, they transform input to output through many layers. 

In CNN layers have a Convolution step, a pooling step (optional) and a non-linear activation. 

Each layer in a neural network transforms the input tensor into the output tensor through linear and non-linear operations. 

All these intermediate tensors (including the network input and output) are called activations and 

they are all different representations of the input.


Why CNN?

We know that Convolutional Neural Networks (CNN) are good at Image Recognition tasks.

Now if we have the Image Recognition task then it also can be done with Simple Neural Networks.

But if theme images are of large pixels then the problem arises as the number of parameters of the Neural Network will also increase. 

That makes Neural Networks very slow and computationally expensive


How CNN works?


The Convolutional Neural Networks can have five, ten or even hundreds of layers that learns to detect different features of a given Image(Say).

Filters are applied to each training image at different resolutions. The output of each convolved image is used as an input 

to the very next layer. 

The filters can be very simple features like brightness, edges, partial shapes and an increase in complexity to features

that uniquely define the given object.


The basic pipeline for CNN is as follows:

1. Input an image.
2. Perform Convolution operation to get an activation map.
3. Apply the pooling layer to make our model robust.
4. Activation function(mostly ReLu) is applied to avoid non-linearity.
5. Flatten the last output into one linear vector.
6. The vector is passed to a fully connected artificial neural network.
7. The fully connected layer will provide a probability for each class that we’re after.
8. Repeat the process to get well defined trained weights and feature detectors.


Basic Terminology and Architecture

1. Convolutional layer: this layer consists of filters and feature maps. 
   Where filters carry the input weights according to that output value and 
   the feature map is the output according to the weight applied on the filter.

   Convolution filter sweeps out features from an image i.e. it tries to learn from an image.
   It computes a dot product between the filter value and the image pixel values to form a convolution layer.



2. Pooling layers: basic work of the pooling layer is to downsample the feature map.

3. Fully connected layer: this is a conventional feed-forward neural network.
 	Which consists of an activation function in order to make predictions.




4.Kernal : In Convolutional neural network, the kernel is nothing but a filter that is used to extract the features from the images. 

            The kernel is a matrix that moves over the input data, performs the dot product with the sub-region of input data, 

            and gets the output as the matrix of dot products.

5. Padding : But what if we don't want to shrink it and want to have the same output matrix as the input matrix.

6. Strides: Strides helps us to reduce the size of matrix

7. Data Augmentation : Ideally, we want our CNN models to be robust to things like rotation, scale, cropping an image etc.

8. Dropout :Dropout refers to ignoring units (Neurons) during the training phase of certain set of neurons which is chosen at random.
   Here ‘ignoring’, means these units are not considered during a particular forward or backward pass.

9. Max Pooling
        The concept of Pooling comes from ‘Location Invariant’ (Identification of the object in an image)
        There is also ‘Scale-Invariant’ (Helps us identify how small or large the object is) and ‘Rotation Invariant’ 
        (Helps us to identify the rotation of the object)

10. Fully Connected Layer
        After the pooling layer, we flattened our data into a vector and feed it into a fully connected layer like in a normal neural network. 
        We have this layer in order to add non-linearity to our data.
        As an example of a human face, the convolutional layer might be able to identify features like faces, mouth, nose, ears etc.
        However, they do not know the position or where these features should be. With the fully connected layers, 
        we combined these features together to create a more complex model that could give the network more prediction power 
        as to where these features should be located in order to classify it as human.


11.ReLU (Rectified Linear Unit)
    As the human brain never stops learning, the brain always learns 
    from the observations and experiences i.e. 
    the inputs which it receives from the sensory organs are utilized at some or another point but the learning never becomes “Zero”.
    To add this feature to the neural networks ReLU is used. 
    The activation function is : f(x) = max(0,x). 
    For any activation function, we must be able to take 
    the derivative of that function and with ReLU we can do that.
    But the derivative at zero is not defined for the ReLU.
    Due to zero, we can have the problem of a dead activation state. 
    This implies there will be no weight change meaning no learning. 
    But for humans, it doesn’t happen very often. To solve this problem the concept of Leaky ReLU is introduced.




Steps of biulding a CNN model
1. First, we need to feed the input into the Convolutional layer
2. Then we have to choose the correct parameters for the convolution includeing filter size, padding and strides.
   Then we will perform Convolution on top of the input image.
3. Then we will apply ReLU on Top of it.
4. We also do pooling to the output to reduce the size.
5. We can add as many Convolution layers as we want and also use dropouts.
6. Then we will flatten the output and feed into a Fully connected layer.
7. Then finally the output will be passed through an Activation function (Sigmoid or Softmax) and we will get the desired result.¶
