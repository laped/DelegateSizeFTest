//
//  DelegateTestLibrary.h
//  DelegateTestLibrary
//
//  Created by Lasse Pedersen on 8/17/12.
//  Copyright (c) 2012 Lasse Pedersen. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol MyTestDataSource;

@interface DelegateTestLibrary : NSObject

@property (assign, nonatomic) id<MyTestDataSource> dataSource;

- (CGSize) executeSizeTest;

@end

@protocol MyTestDataSource <NSObject>

- (CGSize)getSizeForMyTest;

@end
