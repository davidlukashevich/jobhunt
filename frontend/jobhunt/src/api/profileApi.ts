import axios from "axios";

type FormDataType = {
    name: string
    lastName: string
    email: string
    phone: string
    dateOfBirthYear: number | undefined,
    dateOfBirthMonth: number | undefined,
    dateOfBirthDay: number | undefined,
    country: string
    city: string
    street: string
    profileSummary: string
    specialization: string
    file: null | File
}

const profileApi = {
    getProfile(userId: string | null) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/profile/${userId}`, {
            withCredentials: true
        }).then(response => response.data);
    },
    createProfile(formData: FormDataType, userId: string | null) {
        const form = new FormData();
        form.append('name', formData.name);
        form.append('lastName', formData.lastName);
        form.append('email', formData.email);
        form.append('phone', formData.phone);
        form.append('dateOfBirthYear', formData.dateOfBirthYear?.toString() as string);
        form.append('dateOfBirthMonth', formData.dateOfBirthMonth?.toString() as string);
        form.append('dateOfBirthDay', formData.dateOfBirthDay?.toString() as string);
        form.append('country', formData.country);
        form.append('city', formData.city);
        form.append('street', formData.street);
        form.append('profileSummary', formData.profileSummary);
        form.append('specialization', formData.specialization);
        form.append('profileImage', formData.file as File);
        form.append('userId', userId as string);

        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/profile/create', form, {
            withCredentials: true
        }).then(response => response.data);
    },
    updateProfile(profileId: string | null, formData: FormDataType, userId: string | null, addressId: string| null, imageId: string | null) {
        const form = new FormData();
        form.append('name', formData.name);
        form.append('lastname', formData.lastName);
        form.append('email', formData.email);
        form.append('phone', formData.phone);
        form.append('userId', userId as string);
        form.append('dateOfBirthDay', formData.dateOfBirthDay?.toString() as string);
        form.append('dateOfBirthMonth', formData.dateOfBirthMonth?.toString() as string);
        form.append('dateOfBirthYear', formData.dateOfBirthYear?.toString() as string);
        form.append('country', formData.country);
        form.append('city', formData.city);
        form.append('street', formData.street);
        form.append('profileImage', formData.file as File);
        form.append('profileSummary', formData.profileSummary);
        form.append('addressId', addressId as string);
        form.append('profileImageId', imageId as string);
        form.append('profileSummary', formData.profileSummary);
        form.append('specialization', formData.specialization);
        return axios.put(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net//api/profile/update/${profileId}`, form, {
            withCredentials: true,
            headers: {
                "Content-Type": 'multipart/form-data'
            }
        }).then(response => response.data);
    }
}

export default profileApi;