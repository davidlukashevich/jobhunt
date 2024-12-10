import axios from "axios";

type FormDataType = {
    name: string
    lastName: string
    email: string
    phone: string
    dateOfBirthYear: string,
    dateOfBirthMonth: string,
    dateOfBirthDay: string,
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
        form.append('dateOfBirthYear', formData.dateOfBirthYear);
        form.append('dateOfBirthMonth', formData.dateOfBirthMonth);
        form.append('dateOfBirthDay', formData.dateOfBirthDay);
        form.append('country', formData.country);
        form.append('city', formData.city);
        form.append('street', formData.street);
        form.append('profileSummary', formData.profileSummary);
        form.append('specialization', formData.specialization);
        form.append('profileImage', formData.file as File);
        form.append('userId', userId as string);

        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/profile/create', form, {
            withCredentials: true
        });
    }
}

export default profileApi;