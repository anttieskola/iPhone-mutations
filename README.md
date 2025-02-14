# Problem

- I use iPhone XR and now 16 to take pictures and movies
- I use [ifuse](https://github.com/libimobiledevice/ifuse) to copy all images from my iPhone to my hard-drive
  - These DCIM... folders contain all original images
  - Very many images i modify using iPhone and these images
    are stored in different path...

## Example

- XXX is running number that starts from 100, lets use 102 in this example
- Originals path: /DCIM/103APPLE/Image_3942.heic
- Mutations path: /Photodata/Mutations/102APPLE/IMG_3942/Adjustements/FullSizeRender.heic
  - Mutations path contains image name as path
  - Mutations also contain Adjustements.plist that contain every adjustement you made in JSON format
  - Also note that if it's movie original and FullSizeRender suffix is mov

### Plan

- I write a program that travels thru all the mutation paths, detects is it image or movie
- Copies it to Output folder using the original name picked up from path
  - It will also use the base path like 103APPLE in the output
- Using this method I could copy the originals from Output path into my storages and replace non modified ones
  - As i move the folders of outputs that i have moved to other storage to a different name
  - Iphone can show them, but if i open edit, it will crash as there is no mutations path generated for it

#### How to use

- From your phone copy folders /Photodata/Mutations/ content into Mutations folder (it will be most likely just DCIM folder)
  - Will add support for reading mutations data from the mounted phone directory
- Run the program
- It will traverse thru all mutations and copy the modifed versions to Output folder using the original path and name

##### Development

- Find [notes](NOTES.md) from my development process
